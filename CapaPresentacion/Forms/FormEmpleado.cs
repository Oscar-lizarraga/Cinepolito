using System;
using System.Windows.Forms;

using CapaDatos;

namespace CapaPresentacion.Forms
{
    public partial class FormEmpleado : Form
    {
        private int idEmpleado;
        private bool editar;

        public FormEmpleado()
        {
            InitializeComponent();
            this.dataGridViewEmpleados.DataSource = new Cine().MostrarTodosLosEmpleados();
        }


        private void LimpiarControles()
        {
            this.idEmpleado = 0;
            this.editar = false;
            this.textBoxNombreEmpleado.Text = string.Empty;
            this.comboBoxRango.SelectedIndex = -1;
            this.textBoxUsuario.Text = string.Empty;
            this.textBoxContrasena.Text = string.Empty;
            this.textBoxContrasenaVerificada.Text = string.Empty;
            this.dataGridViewEmpleados.DataSource = new Cine().MostrarTodosLosEmpleados();
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = string.Empty;
            if(editar)
            {
                Empleado empleado = new Empleado();
                empleado.IdEmpleado = this.idEmpleado;
                empleado.NombreEmpleado = this.textBoxNombreEmpleado.Text;
                empleado.SetRango(GetRango());
                empleado.Usuario = this.textBoxUsuario.Text;
                empleado.Contrasena = this.textBoxContrasena.Text;
                MessageBox.Show(new Cine().EditarEmpleado(empleado));
            }
            else
            {
                Empleado empleado = new Empleado();
                empleado.NombreEmpleado = this.textBoxNombreEmpleado.Text;
                empleado.SetRango(GetRango());
                empleado.Usuario = this.textBoxUsuario.Text;
                empleado.Contrasena = this.textBoxContrasena.Text;
                MessageBox.Show(new Cine().AgregarEmpleado(empleado));
            }
            this.LimpiarControles();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int i = this.dataGridViewEmpleados.SelectedRows[0].Index;
            this.idEmpleado = Convert.ToInt32(this.dataGridViewEmpleados.Rows[i].Cells["idEmpleado"].Value);
            this.textBoxNombreEmpleado.Text = this.dataGridViewEmpleados.Rows[i].Cells["nombreEmpleado"].Value.ToString();
            this.textBoxUsuario.Text = this.dataGridViewEmpleados.Rows[i].Cells["usuario"].Value.ToString();
            this.textBoxContrasena.Text = this.dataGridViewEmpleados.Rows[i].Cells["contrasena"].Value.ToString();
            this.comboBoxRango.SelectedIndex = Convert.ToInt32(this.dataGridViewEmpleados.Rows[i].Cells["rango"].Value);
            this.editar = true;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(this.dataGridViewEmpleados.Rows.Count > 1)
            {
                int i = this.dataGridViewEmpleados.SelectedRows[0].Index;
                this.idEmpleado = Convert.ToInt32(this.dataGridViewEmpleados.Rows[i].Cells["idEmpleado"].Value);
                Empleado empleado = new Empleado();
                empleado.IdEmpleado = this.idEmpleado;
                MessageBox.Show(new Cine().EliminarEmpleado(empleado));
                this.LimpiarControles();
            }
        }

        private Rango GetRango()
        {
            if(this.comboBoxRango.Text.Equals("General")) return Rango.GENERAL;
            if (this.comboBoxRango.Text.Equals("Supervisor")) return Rango.SUPERVISOR;
            else return Rango.GERENTE;
        }

    }
}
