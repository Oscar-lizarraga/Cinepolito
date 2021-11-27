using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormVentaDulceria : Form
    {

        static FormVentaDulceria formVentaDulceria;
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

        public CapaDatos.FormaPago formaPago;
        public bool pago = false;
        private DataTable articulo = new DataTable();
        private float totalCostoProveedor = 0;


        public FormVentaDulceria()
        {
            InitializeComponent();
            formVentaDulceria = this;
        }

        private void LimpiarControles()
        {
            this.textBoxCodigo.Text = string.Empty;
            this.dataGridViewVenta.Rows.Clear();
            this.labelTotalVenta.Text = ("0.0");
            this.totalCostoProveedor = 0;
            this.articulo.Clear();
        }

        private void AgregarArticulo()
        {
            bool repetido = false;
            articulo = new CapaDatos.Articulo().BuscarArticuloPorCodigo(this.textBoxCodigo.Text);
            if (articulo.Rows.Count != 0)
            {
                if(this.dataGridViewVenta.Rows.Count != 0)
                {
                    foreach (DataGridViewRow row in this.dataGridViewVenta.Rows)
                    {
                        if (row.Cells["codigo"].Value.ToString().ToUpper() == this.textBoxCodigo.Text.ToUpper())
                        {
                            row.Cells["cantidad"].Value = Convert.ToInt32(row.Cells["cantidad"].Value) + 1;
                            row.Cells["importe"].Value = Convert.ToSingle(row.Cells["importe"].Value) + Convert.ToSingle(articulo.Rows[0]["precioVenta"]);
                            this.labelTotalVenta.Text = (Convert.ToSingle(this.labelTotalVenta.Text) + Convert.ToSingle(articulo.Rows[0]["precioVenta"])).ToString("N2");
                            this.totalCostoProveedor = this.totalCostoProveedor + (Convert.ToSingle(articulo.Rows[0]["precioProveedor"]));
                            repetido = true;
                            break;
                        }
                    }
                }
                if(!repetido)
                {
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
            else
            {
                MessageBox.Show("No se encontro el articulo");
            }
            this.textBoxCodigo.Text = string.Empty;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.AgregarArticulo();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewVenta.Rows.Count != 0)
            {
                FormVentaCobrar formVentaCobrar = new FormVentaCobrar(this.labelTotalVenta.Text);
                formVentaCobrar.Show();
            }
            else
            {
                MessageBox.Show("No hay articulos en la venta");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.AgregarArticulo();
            }
        }

        public void IngresarVenta()
        {
            if(this.pago)
            {
                CapaDatos.VentaDulceria ventaDulceria = new CapaDatos.VentaDulceria();
                ventaDulceria.SetFechaVenta(DateTime.Now);
                ventaDulceria.TotalVenta = Convert.ToSingle(this.labelTotalVenta.Text);
                ventaDulceria.TotalCostoProveedor = this.totalCostoProveedor;
                ventaDulceria.TotalArticulos = ObtenerCantidadArticulos();
                ventaDulceria.Articulos = ObtenerArticulos();
                ventaDulceria.FormaPago = this.formaPago;
                string respuesta = ventaDulceria.AgregarVentaDulceria(ventaDulceria);
                if (respuesta.Equals("Registro aceptado"))
                {
                    this.LimpiarControles();
                }
                MessageBox.Show(respuesta);
            }
        }

        private int ObtenerCantidadArticulos()
        {
            int cantidad = 0;
            foreach (DataGridViewRow item in this.dataGridViewVenta.Rows)
            {
                cantidad = cantidad + Convert.ToInt32(item.Cells["cantidad"].Value);
            }
            return cantidad;
        }

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

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            Forms.FormVentasDelDia formVentasDelDia = new FormVentasDelDia();
            formVentasDelDia.Show();
        }
    }
}
