using System;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormVentaCobrar : Form
    {
        private bool pago = false;

        public FormVentaCobrar(string totalVenta)
        {
            InitializeComponent();
            this.labelTotalVenta.Text = totalVenta;
        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if(this.radioButtonEfectivo.Checked && pago == true)
            {
                FormVentaDulceria.Instance.formaPago = CapaDatos.FormaPago.EFECTIVO;
                FormVentaDulceria.Instance.pago = true;
                this.Hide();
                FormVentaDulceria.Instance.IngresarVenta();
            }
            else
            {
                if(this.radioButtonTarjeta.Checked)
                {
                    FormVentaDulceria.Instance.formaPago = CapaDatos.FormaPago.TARJETA;
                    FormVentaDulceria.Instance.pago = true;
                    this.Hide();
                    FormVentaDulceria.Instance.IngresarVenta();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad mayor al total de la venta");
                }
            }
        }

        private void numericUpDownRecibio_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(this.numericUpDownRecibio.Value) - Convert.ToDecimal(this.labelTotalVenta.Text)  >= 0)
            {
                this.textBoxCambio.Text = (Convert.ToDecimal(this.numericUpDownRecibio.Value) - Convert.ToDecimal(this.labelTotalVenta.Text)).ToString();
                this.pago = true;
            }
            else
            {
                this.textBoxCambio.Text = string.Empty;
                this.pago = false;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
