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


        /// <summary>
        /// Este constructor nos muestra por defecto un encabezado diferente al de la tabla por defecto
        /// </summary>
        public FormSala()
        {
            InitializeComponent();
            this.dataGridViewSalas.DataSource = this.CambiarFormato();
            this.dataGridViewSalas.Columns[0].HeaderText = "Numero de sala";
            this.dataGridViewSalas.Columns[1].HeaderText = "Numero de asientos";
            this.dataGridViewSalas.Columns[2].HeaderText = "Tipo de sala";
        }

        /// <summary>
        /// Esta funcion nos devuelve el tipo de sala en vez del numero que lo identifica
        /// </summary>
        /// <returns></returns>
        public TipoSala GetTipoSala()
        {
            if (this.comboBoxTipoSala.SelectedIndex == 0) return TipoSala.TRADICIONAL;
            if (this.comboBoxTipoSala.SelectedIndex == 1) return TipoSala._3D;
            if (this.comboBoxTipoSala.SelectedIndex == 2) return TipoSala._4DX;
            if (this.comboBoxTipoSala.SelectedIndex == 3) return TipoSala.IMAX;
            else return TipoSala.PREMIUM;
        }

        /// <summary>
        /// Esta funcion limpia los componentes y los pone por defecto
        /// </summary>
        private void LimpiarControles()
        {
            this.comboBoxTipoSala.SelectedIndex = -1;
            this.dataGridViewSalas.DataSource = this.CambiarFormato();
            this.numericUpDownAsientos.Value = 0.0M;
            this.editar = false;
            this.idSala = 0;
            this.numeroAsientos = 0;
        }

        
        /// <summary>
        /// Esta funcion agrega las filas a la tabla con un formato personalizado para que no muestre numeros
        /// </summary>
        /// <returns></returns>
        private DataTable CambiarFormato()
        {
            DataTable clonada = new Cine().MostrarTodasLasSalas().Clone();
            clonada.Columns[2].DataType = typeof(string);
            foreach (DataRow item in new Cine().MostrarTodasLasSalas().Rows)
            {
                //Dependiendo del tipo de sala en int se convertira en formato Texto
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

        /// <summary>
        /// Esta funcion devuelve al formato de numeros para los componentes para poder editar la fila seleccionada
        /// </summary>
        /// <param name="tipoSala"></param>
        /// <returns></returns>
        private int DevolverFormato(string tipoSala)
        {
            if (tipoSala.Equals("Tradicional")) return 0;
            if (tipoSala.Equals("3D")) return 1;
            if (tipoSala.Equals("4DX")) return 2;
            if (tipoSala.Equals("IMAX")) return 3;
            else return 4;
        }

        /// <summary>
        /// este evento guarda una nueva sala en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, System.EventArgs e)
        {
            ///Si no se ha seleccionado el tipo de sala pedira que lo seleccione
            if(this.comboBoxTipoSala.SelectedIndex != -1)
            {
                //Si el campo editar esta habilitado quiere decir que se editaran los datos, en caso contrario sera una nueva sala
                if(this.editar)
                {
                    Sala sala = new Sala();
                    sala.IdSala = this.idSala;
                    sala.SetTipoSala = this.GetTipoSala();
                    sala.NumeroAsientos = Convert.ToInt32(this.numericUpDownAsientos.Value);
                    MessageBox.Show(new Cine().EditarSala(sala));
                }
                else
                {
                    Sala sala = new Sala();
                    sala.SetTipoSala = this.GetTipoSala();
                    sala.NumeroAsientos = Convert.ToInt32(this.numericUpDownAsientos.Value);
                    MessageBox.Show(new Cine().AgregarSala(sala));
                }
                this.LimpiarControles();
            }
        }


        /// <summary>
        /// Este evento cancela el ingreso y limpia los componentes del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
            this.LimpiarControles();
        }


        /// <summary>
        /// Este evento edita la fila de la tabla, mandando los datos de la tabla a los componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            //Si no hay filas en la tabla quiere decir que no podremos editar
            if (this.dataGridViewSalas.Rows.Count !=0 )
            {
                // devuelve el indice de la fila seleccionada 
                int i = this.dataGridViewSalas.SelectedRows[0].Index;
                this.idSala = Convert.ToInt32(this.dataGridViewSalas.Rows[i].Cells["idSala"].Value);
                this.numeroAsientos = Convert.ToInt32(this.dataGridViewSalas.Rows[i].Cells["numeroAsientos"].Value);
                this.comboBoxTipoSala.SelectedIndex = DevolverFormato(this.dataGridViewSalas.Rows[i].Cells["tipoSala"].Value.ToString());
                this.editar = true;
            }
        }

        /// <summary>
        /// Este evento elimina datos de la tabla, mandando el idSala a un objeto de tipo sala para poder eliminarlo de la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, System.EventArgs e)
        {
            //Si no hay filas en la tabla quiere decir que no podremos editar
            if (this.dataGridViewSalas.Rows.Count !=0 )
            {
                // devuelve el indice de la fila seleccionada 
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
