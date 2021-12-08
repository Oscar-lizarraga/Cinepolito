using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormFuncion : Form
    {
        /// <summary>
        /// Campos de la clase formfuncion
        /// </summary>
        private bool editar = false;
        private int idFuncion = 0;
        private int  idSala = 0;

        /// <summary>
        /// Constructor por defecto que nos muestra todas las funciones de la fecha actual y muestra todas las salas 
        /// disponibles para agregarles nuevas peliculas 
        /// </summary>
        public FormFuncion()
        {
            InitializeComponent();
            this.dataGridViewFunciones.DataSource = new CapaDatos.Cine().MostrarTodasLasFunciones();
            foreach (DataRow item in new CapaDatos.Cine().MostrarTodasLasSalas().Rows)
            {
                this.comboBoxSalas.Items.Add(item["idSala"].ToString());
            }
        }

        /// <summary>
        /// Funcion que limpia los componentes en su estado por defecto
        /// </summary>
        private void LimpiarControles()
        {
            this.idFuncion = 0;
            this.idSala = 0;
            this.editar = false;
            this.comboBoxSalas.Items.Clear();
            this.comboBoxSalas.Text = "Sala";
            this.textBoxNombreDescripcion.Text = string.Empty;
            this.numericUpDownDuracion.Value = 0;
            this.numericUpDownPrecioVenta.Value = 0;
            this.textBoxGenero.Text = string.Empty;
            this.dateTimePickerFecha.Value = DateTime.Now;
            this.dateTimePickerTiempo.Value = DateTime.Now;
            this.dataGridViewFunciones.DataSource = new CapaDatos.Cine().MostrarTodasLasFunciones();
            foreach (DataRow item in new CapaDatos.Cine().MostrarTodasLasSalas().Rows)
            {
                this.comboBoxSalas.Items.Add(item["idSala"].ToString());
            }
        }

        /// <summary>
        /// Funcion que valida que los componentes tengan datos ingresados correctamente
        /// </summary>
        /// <returns></returns>
        private bool ValidarControles()
        {
            if (this.comboBoxSalas.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una sala");
                return true;
            }
            if (this.textBoxNombreDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una descripcion");
                return true;
            }
            if (this.numericUpDownDuracion.Value <= 0)
            {
                MessageBox.Show("Ingrese una duracion mayor a 0");
                return true;
            }
            if (this.textBoxGenero.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un genero");
                return true;
            }
            if (this.numericUpDownPrecioVenta.Value <= 0)
            {
                MessageBox.Show("Ingrese un precio de venta mayor a 0");
                return true;
            }
            if (this.numericUpDownPrecioVenta.Value == 0) //fecha menores al dia de hoy no validadas
            {
                MessageBox.Show("Ingrese una descripcion");
                return true;
            }
            return false;

        }

        /// <summary>
        /// Evento que guardara una nueva pelicula en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Validamos que los componentes tengan los datos correctamente 
            if (this.ValidarControles()) return;

            //Si la opcion de editar esta habilitada mandaremos llamar al metodo editarFuncion de la clase cine 
            //en caso contrario sera una nueva funcion
            if(this.editar)
            {
                CapaDatos.Funcion funcion = new CapaDatos.Funcion();
                funcion.IdFuncion = this.idFuncion;
                funcion.Descripcion = this.textBoxNombreDescripcion.Text;
                funcion.Duracion = Convert.ToInt32(this.numericUpDownDuracion.Value);
                funcion.Genero = this.textBoxGenero.Text;
                funcion.PrecioVenta = Convert.ToSingle(this.numericUpDownPrecioVenta.Value);
                
                //Pegamos las fechas de dia-mes-año con la hora en la que se estrena la pelicula
                string fecha_aux = this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd ") + this.dateTimePickerTiempo.Value.ToString("hh:mm:ss");
                funcion.SetFecha(Convert.ToDateTime(fecha_aux));
                CapaDatos.Sala sala = new CapaDatos.Sala();
                sala.IdSala = Convert.ToInt32(this.comboBoxSalas.Text);
                MessageBox.Show(new CapaDatos.Cine().EditarFuncion(funcion, sala));
            }
            else
            {
                CapaDatos.Funcion funcion = new CapaDatos.Funcion();
                funcion.Descripcion = this.textBoxNombreDescripcion.Text;
                funcion.Duracion = Convert.ToInt32(this.numericUpDownDuracion.Value);
                funcion.Genero = this.textBoxGenero.Text;
                funcion.PrecioVenta = Convert.ToSingle(this.numericUpDownPrecioVenta.Value);
                string fecha_aux = this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd ") + this.dateTimePickerTiempo.Value.ToString("hh:mm:ss");
                funcion.SetFecha(Convert.ToDateTime(fecha_aux)); 
                CapaDatos.Sala sala = new CapaDatos.Sala();
                sala.IdSala = Convert.ToInt32(this.comboBoxSalas.Text);
                MessageBox.Show(new CapaDatos.Cine().AgregarFuncion(funcion, sala));
            }
            this.LimpiarControles();
        }


        /// <summary>
        /// Este evento cancela el ingreso y limpia los componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        /// <summary>
        /// Este evento edita una funcion de la tabla, especificamente la fila seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //si la tabla no tiene datos no habra nada que editar
            if(this.dataGridViewFunciones.Rows.Count != 0)
            {
                //Nos devuelve el indice en el cual esta posicionada la seleccion en la tabla para poder obtener los datos
                int i = this.dataGridViewFunciones.SelectedRows[0].Index;

                //Enviamos todos los datos de la tabla a los componentes de la funcion para poder editarlos
                this.idFuncion = Convert.ToInt32(this.dataGridViewFunciones.Rows[i].Cells["idFuncion"].Value);
                this.idSala = Convert.ToInt32(this.dataGridViewFunciones.Rows[i].Cells["idSala"].Value);
                this.textBoxNombreDescripcion.Text = this.dataGridViewFunciones.Rows[i].Cells["descripcion"].Value.ToString();
                this.numericUpDownDuracion.Value = Convert.ToInt32(this.dataGridViewFunciones.Rows[i].Cells["duracion"].Value);
                this.textBoxGenero.Text = this.dataGridViewFunciones.Rows[i].Cells["genero"].Value.ToString();
                this.numericUpDownPrecioVenta.Value = Convert.ToDecimal(this.dataGridViewFunciones.Rows[i].Cells["precioVenta"].Value);
                this.dateTimePickerFecha.Value = Convert.ToDateTime(this.dataGridViewFunciones.Rows[i].Cells["fecha"].Value);
                this.dateTimePickerTiempo.Value = Convert.ToDateTime(this.dataGridViewFunciones.Rows[i].Cells["fecha"].Value);
                this.editar = true;
            }
        }

        /// <summary>
        /// Evento que elimina una funcion de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Si no hay elementos en la tabla no habra nada que eliminarS
            if (this.dataGridViewFunciones.Rows.Count != 0)
            {
                //Nos devuelve el indice en el cual esta posicionada la seleccion en la tabla para poder obtener los datos
                int i = this.dataGridViewFunciones.SelectedRows[0].Index;
                CapaDatos.Funcion funcion = new CapaDatos.Funcion();
                
                //Obtenemos el idFuncion para poder eliminar la funcion de la BDD
                funcion.IdFuncion = Convert.ToInt32(this.dataGridViewFunciones.Rows[i].Cells["idFuncion"].Value);
                MessageBox.Show(new CapaDatos.Cine().EliminarFuncion(funcion));
                this.LimpiarControles();
            }
        }
    }
}
