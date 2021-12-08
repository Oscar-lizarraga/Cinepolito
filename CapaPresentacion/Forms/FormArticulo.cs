using System;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormArticulo : Form
    {
        /// <summary>
        /// Campos de la clase formArticulo
        /// </summary>
        private int idArticulo = 0;
        private bool editar = false;

        /// <summary>
        /// Constructor por defecto que inicializa los componentes y mostrar al inicio los articulos que hay
        /// </summary>
        public FormArticulo()
        {
            InitializeComponent();
            this.dataGridViewArticulos.DataSource = new CapaDatos.Articulo().MostrarTodosLosArticulos();
        }

        /// <summary>
        /// Esta funcion limpia todos los componentes que hay en el form en su forma por defecto
        /// </summary>
        private void LimpiarControles()
        {
            this.idArticulo = 0;
            this.editar = false;
            this.textBoxNombreCodigo.Text = string.Empty;
            this.textBoxDescripcion.Text = string.Empty;
            this.numericUpDownPrecioProveedor.Value = 0;
            this.numericUpDownPrecioVenta.Value = 0;
            this.dataGridViewArticulos.DataSource = new CapaDatos.Articulo().MostrarTodosLosArticulos();
        }

        /// <summary>
        /// Esta funcion valida que los datos se hayan ingresado correctamente
        /// </summary>
        /// <returns></returns>
        private bool ValidarControles()
        {
            if(this.textBoxNombreCodigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un codigo");
                return true;
            }
            if(this.textBoxDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una descripcion");
                return true;
            }
            if (this.numericUpDownPrecioProveedor.Value <= 0)
            {
                MessageBox.Show("Ingrese un precio de proveedor mayor a 0");
                return true;
            }
            if (this.numericUpDownPrecioVenta.Value <= 0)
            {
                MessageBox.Show("Ingrese un precio de venta mayor a 0");
                return true;
            }
            if (this.numericUpDownPrecioVenta.Value < this.numericUpDownPrecioProveedor.Value)
            {
                MessageBox.Show("Ingrese un precio de venta mayor al precio de proveedor");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Este evento mandara llamar al metodo agregararticulo de la clase articulo para agregar un nuevo articulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            if (this.ValidarControles()) return;
            //Si esta habilitada la opcion para editar mandaremos llamar al metodo editar, si no, entonces es un nuevo articulo
            if (this.editar)
            {
                //Creamos un nuevo objeto y agregarmos a sus propiedades todos los valores de los componentes que ingreso el usuario
                CapaDatos.Articulo articulo = new CapaDatos.Articulo();
                articulo.Codigo = this.textBoxNombreCodigo.Text;
                articulo.Descripcion = this.textBoxDescripcion.Text;
                articulo.PrecioProveedor = Convert.ToSingle(this.numericUpDownPrecioProveedor.Value);
                articulo.PrecioVenta = Convert.ToSingle(this.numericUpDownPrecioVenta.Value);
                MessageBox.Show(articulo.AgregarArticulo(articulo));
            }
            else
            {
                CapaDatos.Articulo articulo = new CapaDatos.Articulo();
                articulo.Codigo = this.textBoxNombreCodigo.Text;
                articulo.Descripcion = this.textBoxDescripcion.Text;
                articulo.PrecioProveedor = Convert.ToSingle(this.numericUpDownPrecioProveedor.Value);
                articulo.PrecioVenta = Convert.ToSingle(this.numericUpDownPrecioVenta.Value);
                MessageBox.Show(articulo.AgregarArticulo(articulo));
            }
            this.LimpiarControles();
        }

        /// <summary>
        /// Funcion que limpia los componentes porque se cancela el ingreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        /// <summary>
        /// Evento que captura los datos del datatable y los manda a los componentes para poder editarlos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Si no hay ninguna fila en la tabla no podra editar
            if (this.dataGridViewArticulos.Rows.Count != 0)
            {
                //Obtenemos el indice en el cual esta posicionado la seleccion de la tabla
                int i = this.dataGridViewArticulos.SelectedRows[0].Index;

                this.idArticulo = Convert.ToInt32(this.dataGridViewArticulos.Rows[i].Cells["idArticulo"].Value);
                this.textBoxNombreCodigo.Text = this.dataGridViewArticulos.Rows[i].Cells["codigo"].Value.ToString();
                this.textBoxDescripcion.Text = this.dataGridViewArticulos.Rows[i].Cells["descripcion"].Value.ToString();
                this.numericUpDownPrecioProveedor.Value = Convert.ToDecimal(this.dataGridViewArticulos.Rows[i].Cells["precioProveedor"].Value);
                this.numericUpDownPrecioVenta.Value = Convert.ToDecimal(this.dataGridViewArticulos.Rows[i].Cells["precioVenta"].Value);
                this.editar = true;
            }
        }

        /// <summary>
        /// Este evento eliminara el articulo de la tabla mandando el idArticulo al metodo eliminar de la clase articulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewArticulos.Rows.Count != 0)
            {
                int i = this.dataGridViewArticulos.SelectedRows[0].Index;
                CapaDatos.Articulo articulo = new CapaDatos.Articulo();
                articulo.IdArticulo = Convert.ToInt32(this.dataGridViewArticulos.Rows[i].Cells["idArticulo"].Value);
                MessageBox.Show(articulo.EliminarArticulo(articulo));
                this.LimpiarControles();
            }
        }
    }
}
