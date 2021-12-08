using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormVentaTaquilla : Form
    {

        /// <summary>
        /// Se crea una variable static que podra ser usada por la misma instancia
        /// </summary>
        static FormVentaTaquilla formVentaTaquilla;

        /// <summary>
        /// Se crea una propieda que devulve la instancia creada en caso de no existir la crea
        /// </summary>
        public static FormVentaTaquilla Instance
        {
            get
            {
                if (formVentaTaquilla == null)
                {
                    formVentaTaquilla = new FormVentaTaquilla();
                }
                return formVentaTaquilla;
            }
        }


        private int idSala;
        private int idFuncion;
        private float precioFuncion = 0.0F;

        public CapaDatos.FormaPago formaPago;
        public bool pago = false;


        /// <summary>
        /// Constructur que inicializa los componentes del form y guarda la referencia en si misma para poder usarla 
        /// </summary>
        public FormVentaTaquilla()
        {
            InitializeComponent();
            this.CargarControles();
            formVentaTaquilla = this;
        }


        /// <summary>
        /// Funcion que cargara por defecto la descripcion de las peliculas de la fecha en el sistema
        /// </summary>
        private void CargarControles()
        {
            foreach (DataRow item in new CapaDatos.VentaTaquilla().MostrarFuncionesPorFecha(this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd")).Rows)
            {
                this.comboBoxPelicula.Items.Add(item["descripcion"]);
            }
        }


        /// <summary>
        /// Evento que cambiara la descripcion de las peliculas dispobibles al momento de detectar un cambio en la fecha
        /// y limpiara todos los demas controles para que no haya errores de informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            this.comboBoxPelicula.Items.Clear();
            this.comboBoxPelicula.Text = string.Empty;
            this.comboBoxHora.Items.Clear();
            this.comboBoxHora.Text = string.Empty;
            this.comboBoxSala.Items.Clear();
            this.comboBoxSala.Text = string.Empty;
            this.labelAsientos.Text = "0";
            foreach (DataRow item in new CapaDatos.VentaTaquilla().MostrarFuncionesPorFecha(this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd")).Rows)
            {
                this.comboBoxPelicula.Items.Add(item["descripcion"]);
            }
        }

        /// <summary>
        /// Funcion que obtendra las horas disponibles de la descripcion seleccionada, borrara los demas controles en caso de que se cambie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxHora.Items.Clear();
            this.comboBoxHora.Text = string.Empty;
            this.comboBoxSala.Items.Clear();
            this.comboBoxSala.Text = string.Empty;
            this.labelAsientos.Text = "0";
            DataTable dataTable = new CapaDatos.VentaTaquilla().MostrarFuncionesFechaYDescripcion(
            this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd"), this.comboBoxPelicula.Text);
            foreach (DataRow item in dataTable.Rows)
            {
                this.comboBoxHora.Items.Add(Convert.ToDateTime(item["fecha"]).ToString("hh:mm:ss"));
                this.idFuncion = Convert.ToInt32(item["idFuncion"]);
                this.precioFuncion = Convert.ToSingle(item["precioVenta"]);
                this.textBoxPrecioPorBoleto.Text = item["precioVenta"].ToString();
            }
        }

        /// <summary>
        /// Funcion que obtendra el idSala al momento de escoger la hora de la pelicula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxSala.Items.Clear();
            this.comboBoxSala.Text = string.Empty;
            this.labelAsientos.Text = "0";

            foreach (DataRow item in new CapaDatos.VentaTaquilla().MostrarFuncionesFechaDescripcionHora(
                this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd"), this.comboBoxPelicula.Text, this.comboBoxHora.Text).Rows)
            {
                this.comboBoxSala.Items.Add(item["idSala"].ToString());
            }
        }

        /// <summary>
        /// Funcion que obtendra el numero de asientos de la sala y los ocupados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idSala = Convert.ToInt32(this.comboBoxSala.Text);
            this.labelAsientos.Text = "0";
            this.labelAsientosOcupados.Text = (new CapaDatos.VentaTaquilla().NumeroDeAsientosOcupados(this.idFuncion)).ToString();
            this.labelAsientos.Text = new CapaDatos.VentaTaquilla().NumeroDeAsientos(Convert.ToInt32(this.comboBoxSala.Text)).ToString();

        }

        /// <summary>
        /// Funcion que crea un form para proceder al cobro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!this.ValidarControles()) return;
            FormVentaCobrarBoleto formVentaCobrarBoleto = new FormVentaCobrarBoleto(this.precioFuncion * Convert.ToSingle(this.numericUpDownCantidad.Value));
            formVentaCobrarBoleto.Show();
        }

        /// <summary>
        /// Funcion que valida que los controles esten llenados correctamente
        /// </summary>
        /// <returns></returns>
        private bool ValidarControles()
        {
            if (this.comboBoxPelicula.Text == string.Empty) { MessageBox.Show("Seleccione una pelicula"); return false; }
            if (this.comboBoxHora.Text == string.Empty) { MessageBox.Show("Seleccione una hora"); return false; }
            if (this.comboBoxSala.Text == string.Empty) { MessageBox.Show("Seleccione una sala"); return false; }
            if (this.numericUpDownCantidad.Value <= 0.00M) { MessageBox.Show("Debe seleccionar al menos un boleto"); return false; }
            if (new CapaDatos.VentaTaquilla().NumeroDeAsientosOcupados(this.idFuncion) >= Convert.ToInt32(this.labelAsientos.Text))
            {
                MessageBox.Show("No hay asientos disponibles");
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Funcion que cancela la venta y limpia los componentes del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.dateTimePickerFecha.Value = DateTime.Now;
            this.LimpiarControles();
        }


        /// <summary>
        /// Funcion que vuelve a por defecto los componentes del form
        /// </summary>
        private void LimpiarControles()
        {
            this.comboBoxPelicula.Items.Clear();
            this.comboBoxPelicula.Text = string.Empty;
            this.comboBoxHora.Items.Clear();
            this.comboBoxHora.Text = string.Empty;
            this.comboBoxSala.Items.Clear();
            this.comboBoxSala.Text = string.Empty;
            this.labelAsientos.Text = "0";
            this.labelAsientosOcupados.Text = "0";
            this.numericUpDownCantidad.Value = 0.0M;
            this.textBoxPrecioPorBoleto.Text = string.Empty;
            foreach (DataRow item in new CapaDatos.VentaTaquilla().MostrarFuncionesPorFecha(this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd")).Rows)
            {
                this.comboBoxPelicula.Items.Add(item["descripcion"]);
            }
        }

        /// <summary>
        /// Funcion para ingresar la compra de los boletos
        /// </summary>
        public void IngresarCompraBoleto()
        {
            if(this.pago)
            {
                //Se crea un pbjeto funcion para la clave foranea de la tabla ventaBoletos
                CapaDatos.Funcion funcion = new CapaDatos.Funcion();
                funcion.IdFuncion = this.idFuncion;

                //Creamos un objeto venta taquilla donde se guardaran los datos para posterioremente enviarlos a la BDD
                CapaDatos.VentaTaquilla ventaTaquilla = new CapaDatos.VentaTaquilla();
                ventaTaquilla.CantidadBoletos = Convert.ToInt32(this.numericUpDownCantidad.Value);
                ventaTaquilla.TotalVenta = ventaTaquilla.CantidadBoletos * this.precioFuncion;
    
                //Se crea un objeto sala para la clave foranea de la tabla ventaBoletos
                CapaDatos.Sala sala = new CapaDatos.Sala();
                sala.IdSala = this.idSala;

                //Se crea un objeto boleto para almacenar la fecha
                CapaDatos.Boleto boleto = new CapaDatos.Boleto();
                boleto.SetFechaVenta(DateTime.Now);

                CapaDatos.Empleado empleado = new CapaDatos.Empleado();
                empleado.IdEmpleado = new CapaDatos.Cine().ObtenerIDEmpleadoActual();

                //Se llama la funcion de agregar un boleto y esperamos como respuesta "Registro aceptado" si todo funciono correctamente
                string respuesta = ventaTaquilla.AgregarVentaBoleto(funcion, ventaTaquilla, sala, boleto,  empleado);
                if (respuesta.Equals("Registro aceptado"))
                {
                    MessageBox.Show(respuesta);
                    this.dateTimePickerFecha.Value = DateTime.Now;
                    this.LimpiarControles();
                }
                //Si la BDD de lo ingreso se mostrara un mensaje 
                else
                {
                    MessageBox.Show("No se concreto la venta");
                }
            }

        }

        /// <summary>
        /// Funcion que nos mostrar las ventas entre fechas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReportes_Click(object sender, EventArgs e)
        {
            Forms.FormVentasDelDiaBoletos formVentasDelDiaBoletos = new FormVentasDelDiaBoletos();
            formVentasDelDiaBoletos.Show();
        }
    }
}
