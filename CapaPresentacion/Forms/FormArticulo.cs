using System;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormArticulo : Form
    {
        private int idArticulo = 0;
        private bool editar = false;

        public FormArticulo()
        {
            InitializeComponent();
            this.dataGridViewArticulos.DataSource = new CapaDatos.Articulo().MostrarTodosLosArticulos();
        }

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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarControles()) return;
            if (this.editar)
            {
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewArticulos.Rows.Count > 1)
            {
                int i = this.dataGridViewArticulos.SelectedRows[0].Index;
                this.idArticulo = Convert.ToInt32(this.dataGridViewArticulos.Rows[i].Cells["idArticulo"].Value);
                this.textBoxNombreCodigo.Text = this.dataGridViewArticulos.Rows[i].Cells["codigo"].Value.ToString();
                this.textBoxDescripcion.Text = this.dataGridViewArticulos.Rows[i].Cells["descripcion"].Value.ToString();
                this.numericUpDownPrecioProveedor.Value = Convert.ToDecimal(this.dataGridViewArticulos.Rows[i].Cells["precioProveedor"].Value);
                this.numericUpDownPrecioVenta.Value = Convert.ToDecimal(this.dataGridViewArticulos.Rows[i].Cells["precioVenta"].Value);
                this.editar = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewArticulos.Rows.Count > 1)
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
