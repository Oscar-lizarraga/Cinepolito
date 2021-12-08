using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormVentaDulceria : Form
    {

        /// <summary>
        /// Variable static de tipo formventadulceria que almacenara la mismainstancia que se creo para poder obtener acceso a esa direccion
        /// desde otro form
        /// </summary>
        static FormVentaDulceria formVentaDulceria;

        /// <summary>
        /// propiedad que obtiene la direccion del form actual en su defecto de no existir creara una nueva
        /// </summary>
        public static FormVentaDulceria Instance
        {
            get
            {
                if (formVentaDulceria == null)
                {
                    formVentaDulceria = new FormVentaDulceria();
                }
                return formVentaDulceria;
            }
        }

        /// <summary>
        /// Campos de la clase formVentaDulceria necesarios para poder almacenar datos para mandarlos a la ventaDulceria
        /// </summary>
        public CapaDatos.FormaPago formaPago;
        public bool pago = false;
        private DataTable articulo = new DataTable();
        private float totalCostoProveedor = 0;

        /// <summary>
        /// Constructor por defecto que almacena la direccion del objeto en la misma clase
        /// </summary>
        public FormVentaDulceria()
        {
            InitializeComponent();
            formVentaDulceria = this;
        }

        /// <summary>
        /// Funcion que limpia los controles a su estado por defecto
        /// </summary>
        private void LimpiarControles()
        {
            this.textBoxCodigo.Text = string.Empty;
            this.dataGridViewVenta.Rows.Clear();
            this.labelTotalVenta.Text = ("0.0");
            this.totalCostoProveedor = 0;
            this.articulo.Clear();
        }

        /// <summary>
        /// Funcion que agrega un nuevo articulo a la tabla
        /// </summary>
        private void AgregarArticulo()
        {
            //Si el articulo ya esta en la tabla solo sera sumar el total del importe 
            bool repetido = false;
            articulo = new CapaDatos.Articulo().BuscarArticuloPorCodigo(this.textBoxCodigo.Text);

            //si la BDD no devuelve una tabla con el articulo no se encontro el articulo
            if (articulo.Rows.Count != 0)
            {
                //Si nuestra tabla contiene filas esto quiere decir que el articulo se puede repetir
                if(this.dataGridViewVenta.Rows.Count != 0)
                {
                    foreach (DataGridViewRow row in this.dataGridViewVenta.Rows)
                    {
                        //Buscamos en la tabla si algun articulo se repite
                        if (row.Cells["codigo"].Value.ToString().ToUpper() == this.textBoxCodigo.Text.ToUpper())
                        {
                            row.Cells["cantidad"].Value = Convert.ToInt32(row.Cells["cantidad"].Value) + 1;
                            row.Cells["importe"].Value = Convert.ToSingle(row.Cells["importe"].Value) + Convert.ToSingle(articulo.Rows[0]["precioVenta"]);
                            this.labelTotalVenta.Text = (Convert.ToSingle(this.labelTotalVenta.Text) + Convert.ToSingle(articulo.Rows[0]["precioVenta"])).ToString("N2");
                            this.totalCostoProveedor = this.totalCostoProveedor + (Convert.ToSingle(articulo.Rows[0]["precioProveedor"]));
                            
                            //si se repite hacemos saber a la condicion de que si existe si no, creara una nueva fila
                            repetido = true;
                            break;
                        }
                    }
                }
                //Si no esta repetido agregaremos una nueva fila a la tabla con los datos obtenidos del articulo encontrado
                if(!repetido)
                {
                    //para tener mejor legibilidad accedemos a los datos como una fila en ves de Datatable
                    foreach (DataRow row in articulo.Rows)
                    {
                        this.dataGridViewVenta.Rows.Add(
                            row["idArticulo"],
                            row["codigo"],
                            row["descripcion"],
                            1/*cantidad*/,
                            row["precioVenta"],
                            row["precioVenta"]/*importe*/);
                        this.labelTotalVenta.Text = (Convert.ToSingle(this.labelTotalVenta.Text) + Convert.ToSingle(row["precioVenta"])).ToString("N2");
                        this.totalCostoProveedor = this.totalCostoProveedor + Convert.ToSingle(row["precioProveedor"]);
                    }
                }
            }
            //Si no se encontro el codigo del articulo
            else
            {
                MessageBox.Show("No se encontro el articulo");
            }
            this.textBoxCodigo.Text = string.Empty;
        }

        /// <summary>
        /// Este evento del boton ingresar, ingresa el articulo en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.AgregarArticulo();
        }

        /// <summary>
        /// Este evento cancela la venta y limpia los componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        /// <summary>
        /// Este evento manda llamar otro form que verificara el cobro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewVenta.Rows.Count != 0)
            {
                FormVentaCobrar formVentaCobrar = new FormVentaCobrar(this.labelTotalVenta.Text);
                formVentaCobrar.Show();
            }
            //Si no hay articulos no podremos cobrar
            else
            {
                MessageBox.Show("No hay articulos en la venta");
            }
        }

        /// <summary>
        /// Este evento hara que se pueda ingresar el articulo si el textBox articulo tiene el Focus y presionamos la tecla enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.AgregarArticulo();
            }
        }

        /// <summary>
        /// Esta funcion mandara llamar el metodo para ingresar una nueva venta en la BDD
        /// </summary>
        public void IngresarVenta()
        {
            //Si el pago se efectuo entonces podremos ingresar la venta
            if(this.pago)
            {

                CapaDatos.Empleado empleado = new CapaDatos.Empleado();
                empleado.IdEmpleado = new CapaDatos.Cine().ObtenerIDEmpleadoActual();

                CapaDatos.VentaDulceria ventaDulceria = new CapaDatos.VentaDulceria();
                ventaDulceria.SetFechaVenta(DateTime.Now);
                ventaDulceria.TotalVenta = Convert.ToSingle(this.labelTotalVenta.Text);
                ventaDulceria.TotalCostoProveedor = this.totalCostoProveedor;
                ventaDulceria.TotalArticulos = ObtenerCantidadArticulos();
                ventaDulceria.Articulos = ObtenerArticulos();
                ventaDulceria.FormaPago = this.formaPago;
                string respuesta = ventaDulceria.AgregarVentaDulceria(ventaDulceria, empleado);

                //Si hubo algo mal con el ingreso mostrara en pantalla que fue
                if (respuesta.Equals("Registro aceptado"))
                {
                    this.LimpiarControles();
                }
                MessageBox.Show(respuesta);
            }
        }

        /// <summary>
        /// Esta funcion obtiene la cantidad de articulos totales de la venta
        /// </summary>
        /// <returns></returns>
        private int ObtenerCantidadArticulos()
        {
            int cantidad = 0;
            foreach (DataGridViewRow item in this.dataGridViewVenta.Rows)
            {
                cantidad = cantidad + Convert.ToInt32(item.Cells["cantidad"].Value);
            }
            return cantidad;
        }

        /// <summary>
        /// Esta funcion obtiene todos los articulos de la tabla y los almacena en una lista para poder 
        /// ingresarlos en la BDD de detalles de venta
        /// </summary>
        /// <returns></returns>
        private List<CapaDatos.Articulo> ObtenerArticulos()
        {
            List<CapaDatos.Articulo> articulos = new List<CapaDatos.Articulo>();
            foreach (DataGridViewRow item in this.dataGridViewVenta.Rows)
            {
                CapaDatos.Articulo articulo = new CapaDatos.Articulo();
                articulo.IdArticulo = Convert.ToInt32(item.Cells["idArticulo"].Value);
                articulos.Add(articulo);
            }
            return articulos;
        }

        /// <summary>
        /// Este evento manda llamar el form para poder ver las ventas entre fechas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVentas_Click(object sender, EventArgs e)
        {
            Forms.FormVentasDelDia formVentasDelDia = new FormVentasDelDia();
            formVentasDelDia.Show();
        }
    }
}
