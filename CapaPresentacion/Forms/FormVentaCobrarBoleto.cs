using System;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormVentaCobrarBoleto : Form
    {
        private bool pago = false;


        /// <summary>
        /// Constructor que inicializa los componentes 
        /// </summary>
        /// <param name="totalVenta">El total de la venta de los boletos</param>
        public FormVentaCobrarBoleto(float totalVenta)
        {
            InitializeComponent();
            this.labelTotalVenta.Text = totalVenta.ToString();
        }

        /// <summary>
        /// Funcion que agregara al FormVentaTaquilla los campos formaPago y para verificar si pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            //Si esta rellenado el boton de efectivo la compra sera en efectivo
            if (this.radioButtonEfectivo.Checked && pago == true)
            {
                FormVentaTaquilla.Instance.formaPago = CapaDatos.FormaPago.EFECTIVO;
                FormVentaTaquilla.Instance.pago = true;
                this.Hide();
                FormVentaTaquilla.Instance.IngresarCompraBoleto();
            }
            else
            {
                //Si esta rellenado el boton de tarjeta la compra sera en tarjeta
                if (this.radioButtonTarjeta.Checked)
                {
                    FormVentaTaquilla.Instance.formaPago = CapaDatos.FormaPago.TARJETA;
                    FormVentaTaquilla.Instance.pago = true;
                    this.Hide();
                    FormVentaTaquilla.Instance.IngresarCompraBoleto();
                }
                else
                {
                    //Si el total de recibio no es mayor a la venta no se podra realizar la compra
                    MessageBox.Show("Ingrese una cantidad mayor al total de la venta");
                }
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }

        /// <summary>
        /// Funcion que nos determinara el cambio necesario para realizar la venta, y en su defecto habilitara el acceso para poder finalizar la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownRecibio_ValueChanged_1(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(this.numericUpDownRecibio.Value) - Convert.ToDecimal(this.labelTotalVenta.Text) >= 0)
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

        /// <summary>
        /// Evento que cambiara el estado a inaccesible de los componentes recibio y cambio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            this.numericUpDownRecibio.Enabled = false;
            this.textBoxCambio.Enabled = false;

        }

        /// <summary>
        /// Evento que camviara el estado a accesible de los componentes recibio y cambio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            this.numericUpDownRecibio.Enabled = false;
            this.textBoxCambio.Enabled = false;
        }
    }
}
