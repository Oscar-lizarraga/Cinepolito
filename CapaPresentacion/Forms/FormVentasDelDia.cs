using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormVentasDelDia : Form
    {
        public FormVentasDelDia()
        {
            InitializeComponent();
            Cargar();
        }

        private void Cargar()
        {
            this.dataGridViewVentas.DataSource = new CapaDatos.VentaDulceria().MostrarVentasPorFecha(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            this.CalcularGanancias();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewVentas.DataSource =
                new CapaDatos.VentaDulceria().MostrarVentasPorFecha(
                    this.dateTimePickerFechaInicial.Value.ToString("yyyy-MM-dd"),
                    this.dateTimePickerFechaFinal.Value.ToString("yyyy-MM-dd"));
            this.CalcularGanancias();
        }

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
