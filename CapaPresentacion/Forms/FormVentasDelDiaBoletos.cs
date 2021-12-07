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
    public partial class FormVentasDelDiaBoletos : Form
    {
        public FormVentasDelDiaBoletos()
        {
            InitializeComponent();
            this.Cargar();
        }



        private void Cargar()
        {
            this.dataGridViewVentas.DataSource = new CapaDatos.VentaDulceria().MostrarVentasPorFecha(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            this.CalcularGanancias();
        }

        private void CalcularGanancias()
        {
            this.labelVentasTotales.Text = "0.0";
            if (this.dataGridViewVentas.Rows.Count != 0)
            {
                foreach (DataGridViewRow item in this.dataGridViewVentas.Rows)
                {
                    this.labelVentasTotales.Text = (Convert.ToSingle(this.labelVentasTotales.Text) + Convert.ToSingle(item.Cells["totalVenta"].Value)).ToString("N2");
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewVentas.DataSource =
            new CapaDatos.VentaTaquilla().MostrarVentasPorFecha(
                this.dateTimePickerFechaInicial.Value.ToString("yyyy-MM-dd"),
                this.dateTimePickerFechaFinal.Value.ToString("yyyy-MM-dd"));
            this.CalcularGanancias();
        }
    }
}
