using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormFuncion : Form
    {
        private bool editar = false;
        private int idFuncion = 0;
        private int  idSala = 0;




        public FormFuncion()
        {
            InitializeComponent();
            this.dataGridViewFunciones.DataSource = new CapaDatos.Cine().MostrarTodasLasFunciones();
            foreach (DataRow item in new CapaDatos.Cine().MostrarTodasLasSalas().Rows)
            {
                this.comboBoxSalas.Items.Add(item["idSala"].ToString());
            }
        }

        private void LimpiarControles()
        {
            this.idFuncion = 0;
            this.idSala = 0;
            this.editar = false;
            this.comboBoxSalas.SelectedIndex = -1;
            this.textBoxNombreDescripcion.Text = string.Empty;
            this.numericUpDownDuracion.Value = 0;
            this.numericUpDownPrecioVenta.Value = 0;
            this.textBoxGenero.Text = string.Empty;
            this.dateTimePickerFecha.Value = DateTime.Now;
            this.dateTimePickerTiempo.Value = DateTime.Now;
            this.dataGridViewFunciones.DataSource = new CapaDatos.Cine().MostrarTodasLasFunciones();
            foreach (DataRow item in new CapaDatos.Cine().MostrarTodasLasSalas().Rows)
            {
                this.comboBoxSalas.Items.Add(item["idSala"].ToString());
            }
        }

        private bool ValidarControles()
        {
            if (this.comboBoxSalas.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una sala");
                return true;
            }
            if (this.textBoxNombreDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una descripcion");
                return true;
            }
            if (this.numericUpDownDuracion.Value <= 0)
            {
                MessageBox.Show("Ingrese una duracion mayor a 0");
                return true;
            }
            if (this.textBoxGenero.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un genero");
                return true;
            }
            if (this.numericUpDownPrecioVenta.Value <= 0)
            {
                MessageBox.Show("Ingrese un precio de venta mayor a 0");
                return true;
            }
            if (this.numericUpDownPrecioVenta.Value == 0) //fecha menores al dia de hoy no validadas
            {
                MessageBox.Show("Ingrese una descripcion");
                return true;
            }
            return false;

        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarControles()) return;
            if(this.editar)
            {
                CapaDatos.Funcion funcion = new CapaDatos.Funcion();
                funcion.IdFuncion = this.idFuncion;
                funcion.Descripcion = this.textBoxNombreDescripcion.Text;
                funcion.Duracion = Convert.ToInt32(this.numericUpDownDuracion.Value);
                funcion.Genero = this.textBoxGenero.Text;
                funcion.PrecioVenta = Convert.ToSingle(this.numericUpDownPrecioVenta.Value);
                string fecha_aux = this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd ") + this.dateTimePickerTiempo.Value.ToString("hh:mm:ss");
                funcion.SetFecha(Convert.ToDateTime(fecha_aux));
                CapaDatos.Sala sala = new CapaDatos.Sala();
                sala.IdSala = Convert.ToInt32(this.comboBoxSalas.Text);
                MessageBox.Show(new CapaDatos.Cine().EditarFuncion(funcion, sala));
            }
            else
            {
                CapaDatos.Funcion funcion = new CapaDatos.Funcion();
                funcion.Descripcion = this.textBoxNombreDescripcion.Text;
                funcion.Duracion = Convert.ToInt32(this.numericUpDownDuracion.Value);
                funcion.Genero = this.textBoxGenero.Text;
                funcion.PrecioVenta = Convert.ToSingle(this.numericUpDownPrecioVenta.Value);
                string fecha_aux = this.dateTimePickerFecha.Value.ToString("yyyy-MM-dd ") + this.dateTimePickerTiempo.Value.ToString("hh:mm:ss");
                funcion.SetFecha(Convert.ToDateTime(fecha_aux)); 
                CapaDatos.Sala sala = new CapaDatos.Sala();
                sala.IdSala = Convert.ToInt32(this.comboBoxSalas.Text);
                MessageBox.Show(new CapaDatos.Cine().AgregarFuncion(funcion, sala));
            }
            this.LimpiarControles();
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(this.dataGridViewFunciones.Rows.Count > 1)
            {
                int i = this.dataGridViewFunciones.SelectedRows[0].Index;
                this.idFuncion = Convert.ToInt32(this.dataGridViewFunciones.Rows[i].Cells["idFuncion"].Value);
                this.idSala = Convert.ToInt32(this.dataGridViewFunciones.Rows[i].Cells["idSala"].Value);
                this.textBoxNombreDescripcion.Text = this.dataGridViewFunciones.Rows[i].Cells["descripcion"].Value.ToString();
                this.numericUpDownDuracion.Value = Convert.ToInt32(this.dataGridViewFunciones.Rows[i].Cells["duracion"].Value);
                this.textBoxGenero.Text = this.dataGridViewFunciones.Rows[i].Cells["genero"].Value.ToString();
                this.numericUpDownPrecioVenta.Value = Convert.ToDecimal(this.dataGridViewFunciones.Rows[i].Cells["precioVenta"].Value);
                this.dateTimePickerFecha.Value = Convert.ToDateTime(this.dataGridViewFunciones.Rows[i].Cells["fecha"].Value);
                this.dateTimePickerTiempo.Value = Convert.ToDateTime(this.dataGridViewFunciones.Rows[i].Cells["fecha"].Value);
                this.editar = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewFunciones.Rows.Count > 1)
            {
                int i = this.dataGridViewFunciones.SelectedRows[0].Index;
                CapaDatos.Funcion funcion = new CapaDatos.Funcion();
                funcion.IdFuncion = Convert.ToInt32(this.dataGridViewFunciones.Rows[i].Cells["idFuncion"].Value);
                MessageBox.Show(new CapaDatos.Cine().EliminarFuncion(funcion));
                this.LimpiarControles();
            }
        }
    }
}
