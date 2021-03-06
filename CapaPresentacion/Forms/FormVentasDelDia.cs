using System;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormVentasDelDia : Form
    {
        public FormVentasDelDia()
        {
            InitializeComponent();
            this.Cargar();
        }

        /// <summary>
        /// Funcion que carga las ventas del dia del sistema
        /// </summary>
        private void Cargar()
        {
            this.dataGridViewVentas.DataSource = new CapaDatos.VentaDulceria().MostrarVentasPorFecha(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            this.CalcularGanancias();
        }

        /// <summary>
        /// Evento que manda a traer las consultas de las ventas entre determinadas fechas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewVentas.DataSource =
                new CapaDatos.VentaDulceria().MostrarVentasPorFecha(
                    this.dateTimePickerFechaInicial.Value.ToString("yyyy-MM-dd"),
                    this.dateTimePickerFechaFinal.Value.ToString("yyyy-MM-dd"));
            this.CalcularGanancias();
        }

        /// <summary>
        /// Funcion que muestra en un label las ganancias entre las fechas indicadas
        /// </summary>
        private void CalcularGanancias()
        {
            this.labelVentasTotales.Text = "0.0";
            this.labelCostoTotal.Text = "0.0";
            this.labelGanancia.Text = "0.0";
            if(this.dataGridViewVentas.Rows.Count != 0)
            {
                foreach (DataGridViewRow item in this.dataGridViewVentas.Rows)
                {
                    this.labelVentasTotales.Text = (Convert.ToSingle(this.labelVentasTotales.Text) + Convert.ToSingle(item.Cells["totalVenta"].Value)).ToString("N2");
                    this.labelCostoTotal.Text = (Convert.ToSingle(this.labelCostoTotal.Text) + Convert.ToSingle(item.Cells["totalCostoProveedor"].Value)).ToString("N2");
                }
            }
            this.labelGanancia.Text = (Convert.ToSingle(this.labelVentasTotales.Text) - Convert.ToSingle(this.labelCostoTotal.Text)).ToString("N2");
        }



    }
}
