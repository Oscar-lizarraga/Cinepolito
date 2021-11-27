using System;
using System.Data;
using System.Windows.Forms;

using CapaDatos;

namespace CapaPresentacion.Forms
{
    public partial class FormSala : Form
    {
        private int idSala;
        private bool editar;
        private int numeroAsientos;

        public FormSala()
        {
            InitializeComponent();
            this.dataGridViewSalas.DataSource = this.CambiarFormato();
            this.dataGridViewSalas.Columns[0].HeaderText = "Numero de sala";
            this.dataGridViewSalas.Columns[1].HeaderText = "Numero de asientos";
            this.dataGridViewSalas.Columns[2].HeaderText = "Tipo de sala";
        }

        public TipoSala GetTipoSala()
        {
            if (this.comboBoxTipoSala.SelectedIndex == 0) return TipoSala.TRADICIONAL;
            if (this.comboBoxTipoSala.SelectedIndex == 1) return TipoSala._3D;
            if (this.comboBoxTipoSala.SelectedIndex == 2) return TipoSala._4DX;
            if (this.comboBoxTipoSala.SelectedIndex == 3) return TipoSala.IMAX;
            else return TipoSala.PREMIUM;
        }

        private void LimpiarControles()
        {
            this.comboBoxTipoSala.SelectedIndex = -1;
            this.dataGridViewSalas.DataSource = this.CambiarFormato();
            this.editar = false;
            this.idSala = 0;
            this.numeroAsientos = 0;
        }

        private DataTable CambiarFormato()
        {
            DataTable clonada = new Cine().MostrarTodasLasSalas().Clone();
            clonada.Columns[2].DataType = typeof(string);
            foreach (DataRow item in new Cine().MostrarTodasLasSalas().Rows)
            {
                switch(Convert.ToInt32(item["tipoSala"]))
                {
                    case 0:
                        clonada.Rows.Add(item["idSala"], item["numeroAsientos"], "Tradicional");
                        break;
                    case 1:
                        clonada.Rows.Add(item["idSala"], item["numeroAsientos"], "3D");
                        break;
                    case 2:
                        clonada.Rows.Add(item["idSala"], item["numeroAsientos"], "4DX");
                        break;
                    case 3:
                        clonada.Rows.Add(item["idSala"], item["numeroAsientos"], "IMAX");
                        break;
                    case 4:
                        clonada.Rows.Add(item["idSala"], item["numeroAsientos"], "PREMIUM");
                        break;
                    default:
                        break;
                }
            }
            return clonada;
        }

        private int DevolverFormato(string tipoSala)
        {
            if (tipoSala.Equals("Tradicional")) return 0;
            if (tipoSala.Equals("3D")) return 1;
            if (tipoSala.Equals("4DX")) return 2;
            if (tipoSala.Equals("IMAX")) return 3;
            else return 4;
        }


        private void buttonGuardar_Click(object sender, System.EventArgs e)
        {
            if(this.comboBoxTipoSala.SelectedIndex != -1)
            {
                if(this.editar)
                {
                    Sala sala = new Sala();
                    sala.IdSala = this.idSala;
                    sala.SetTipoSala = this.GetTipoSala();
                    sala.NumeroAsientos = this.numeroAsientos;
                    MessageBox.Show(new Cine().EditarSala(sala));
                }
                else
                {
                    Sala sala = new Sala();
                    sala.SetTipoSala = this.GetTipoSala();
                    sala.NumeroAsientos = 0;
                    MessageBox.Show(new Cine().AgregarSala(sala));
                }
                this.LimpiarControles();
            }
        }

        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
            this.LimpiarControles();
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            int i = this.dataGridViewSalas.SelectedRows[0].Index;
            this.idSala = Convert.ToInt32(this.dataGridViewSalas.Rows[i].Cells["idSala"].Value);
            this.numeroAsientos = Convert.ToInt32(this.dataGridViewSalas.Rows[i].Cells["numeroAsientos"].Value);
            this.comboBoxTipoSala.SelectedIndex = DevolverFormato(this.dataGridViewSalas.Rows[i].Cells["tipoSala"].Value.ToString());
            this.editar = true;
        }

        private void buttonEliminar_Click(object sender, System.EventArgs e)
        {
            if (this.dataGridViewSalas.Rows.Count > 1)
            {
                int i = this.dataGridViewSalas.SelectedRows[0].Index;
                this.idSala = Convert.ToInt32(this.dataGridViewSalas.Rows[i].Cells["idSala"].Value);
                Sala sala = new Sala();
                sala.IdSala = this.idSala;
                MessageBox.Show(new Cine().EliminarSala(sala));
                this.LimpiarControles();
            }
        }


    }
}
