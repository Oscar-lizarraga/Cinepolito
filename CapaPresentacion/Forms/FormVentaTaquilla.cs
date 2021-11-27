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
    public partial class FormVentaTaquilla : Form
    {
        private int idSala;
        public FormVentaTaquilla()
        {
            InitializeComponent();
            this.CargarControles();
        }

        private void LimpiarControles()
        {
        }


        private void CargarControles()
        {
            foreach (DataRow item in new CapaDatos.VentaTaquilla().MostrarFuncionesPorFecha(this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd")).Rows)
            {
                this.comboBoxPelicula.Items.Add(item["descripcion"]);
            }
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            this.comboBoxPelicula.Items.Clear();
            this.comboBoxPelicula.Text = string.Empty;
            this.comboBoxHora.Items.Clear();
            this.comboBoxHora.Text = string.Empty;
            this.comboBoxSala.Items.Clear();
            this.comboBoxSala.Text = string.Empty;
            this.labelAsientos.Text = "0";
            foreach (DataRow item in new CapaDatos.VentaTaquilla().MostrarFuncionesPorFecha(this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd")).Rows)
            {
                this.comboBoxPelicula.Items.Add(item["descripcion"]);
            }
        }

        private void comboBoxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxHora.Items.Clear();
            this.comboBoxHora.Text = string.Empty;
            this.comboBoxSala.Items.Clear();
            this.comboBoxSala.Text = string.Empty;
            this.labelAsientos.Text = "0";
            DataTable dataTable = new CapaDatos.VentaTaquilla().MostrarFuncionesFechaYDescripcion(
                this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd"), this.comboBoxPelicula.Text);
            foreach (DataRow item in dataTable.Rows)
            {
                this.comboBoxHora.Items.Add(Convert.ToDateTime(item["fecha"]).ToString("hh:mm:ss"));
            }
        }

        private void comboBoxHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxSala.Items.Clear();
            this.comboBoxSala.Text = string.Empty;
            this.labelAsientos.Text = "0";

            foreach (DataRow item in new CapaDatos.VentaTaquilla().MostrarFuncionesFechaDescripcionHora(
                this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd"), this.comboBoxPelicula.Text, this.comboBoxHora.Text).Rows)
            {
                this.comboBoxSala.Items.Add(item["idSala"].ToString());
            }
        }

        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelAsientos.Text = "0";
            this.labelAsientos.Text = new CapaDatos.VentaTaquilla().NumeroDeAsientos(Convert.ToInt32(this.comboBoxSala.Text)).ToString();

        }
    }
}
