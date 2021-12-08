using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Este evento nos permite ingresar al siguiente form dependiendo del acceso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIngresar_Click(object sender, System.EventArgs e)
        {
            CapaDatos.Cine cine = new CapaDatos.Cine();
            DataTable dataTable = new DataTable();
            dataTable = cine.VerificarAcceso(this.textBoxUsuario.Text, this.textBoxContraseña.Text);

            //Verificamos si el datatable que verifica si tiene acceso tiene contenido , si no, entonces no tiene acceso
            if(dataTable.Rows.Count != 0)
            {
                CapaDatos.Empleado empleado = new CapaDatos.Empleado();
                empleado.IdEmpleado = Convert.ToInt32(dataTable.Rows[0][0]);

                //Ingresamos en la tabla empleado actual el id del empleado
                cine.IngresarEmpleadoActual(empleado);
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                //Por defecto podemos entrar con permisos de administrador
                if(this.textBoxUsuario.Text == "Admin" && this.textBoxContraseña.Text == "12345")
                {
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No tiene permisos de acceso");
                    this.textBoxUsuario.Text = string.Empty;
                    this.textBoxContraseña.Text = string.Empty;
                    this.textBoxUsuario.Focus();
                }
            }
        }

        /// <summary>
        /// Este evento cancela el ingreso y limpia los componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.textBoxUsuario.Text = string.Empty;
            this.textBoxContraseña.Text = string.Empty;
            this.textBoxUsuario.Focus();
        }
    }
}
