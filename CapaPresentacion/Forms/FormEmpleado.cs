using System;
using System.Windows.Forms;

using CapaDatos;

namespace CapaPresentacion.Forms
{
    public partial class FormEmpleado : Form
    {
        /// <summary>
        /// Campos de la clase formEmpleado
        /// </summary>
        private int idEmpleado;
        private bool editar;

        /// <summary>
        /// Constructor por defecto que inicializa los componentes y muestra al iniciar todos los empleados en la tabla
        /// </summary>
        public FormEmpleado()
        {
            InitializeComponent();
            this.dataGridViewEmpleados.DataSource = new Cine().MostrarTodosLosEmpleados();
        }

        /// <summary>
        /// Funcion que limpia los componentes a su estado por defecto 
        /// </summary>
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

        /// <summary>
        /// Evento que mandara llamar al metodo editarEmpleado o agregarEmpleado de la clase empleado, para hacer modificaciones en la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //validamos que los componentes tengan datos validos
            if (this.validarControles()) return;
            //Si la opcion editar esta habilitada mandara llamar al metodo para editar en caso contrario sera un nuevo empleado
            if(editar)
            {
                //Creamos un nuevo empleado e ingresamos en sus propiedades los datos de los componentes
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

        /// <summary>
        /// Evento que cancela el ingreso y limpia los componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        /// <summary>
        /// Este evento obtiene los datos de la tabla para mandarlos a los componentes y asi poder editarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Verificamos que haya un empleado en la tabla en caso contrario no hay datos que pasar
            if (this.dataGridViewEmpleados.Rows.Count != 0)
            {
                int i = this.dataGridViewEmpleados.SelectedRows[0].Index;
                this.idEmpleado = Convert.ToInt32(this.dataGridViewEmpleados.Rows[i].Cells["idEmpleado"].Value);
                this.textBoxNombreEmpleado.Text = this.dataGridViewEmpleados.Rows[i].Cells["nombreEmpleado"].Value.ToString();
                this.textBoxUsuario.Text = this.dataGridViewEmpleados.Rows[i].Cells["usuario"].Value.ToString();
                this.textBoxContrasena.Text = this.dataGridViewEmpleados.Rows[i].Cells["contrasena"].Value.ToString();
                this.comboBoxRango.SelectedIndex = Convert.ToInt32(this.dataGridViewEmpleados.Rows[i].Cells["rango"].Value);
                this.editar = true;
            }
        }

        /// <summary>
        /// Evento que elimina un usuario de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Verificamos que haya un empleado que eliminar en la tabla en caso contrario no podemos eliminar
            if(this.dataGridViewEmpleados.Rows.Count != 0)
            {
                //Nos devuelve el index de la tabla en el cual esta posicionado la seleccion
                int i = this.dataGridViewEmpleados.SelectedRows[0].Index;
                this.idEmpleado = Convert.ToInt32(this.dataGridViewEmpleados.Rows[i].Cells["idEmpleado"].Value);

                //Creamos un empleado y pasamos el idEmpleado para saber que empleado eliminar en la BDD
                Empleado empleado = new Empleado();
                empleado.IdEmpleado = this.idEmpleado;
                MessageBox.Show(new Cine().EliminarEmpleado(empleado));
                this.LimpiarControles();
            }
        }

        /// <summary>
        /// Funcion que obtiene el tipo de rango dependiendo de que texto este seleccionado en el combobox del rango
        /// </summary>
        /// <returns></returns>
        private Rango GetRango()
        {
            if(this.comboBoxRango.Text.Equals("General")) return Rango.GENERAL;
            if (this.comboBoxRango.Text.Equals("Supervisor")) return Rango.SUPERVISOR;
            else return Rango.GERENTE;
        }

        /// <summary>
        /// Funcion que verifica que los datos de los controles hayan sido ingresados correctamente
        /// </summary>
        /// <returns></returns>
        private bool validarControles()
        {
            if (this.textBoxNombreEmpleado.Text == string.Empty) { MessageBox.Show("Ingrese un nombre de empleado"); return true; }
            if (this.comboBoxRango.SelectedIndex == -1) { MessageBox.Show("Ingrese un rando para el empleado"); return true; }
            if (this.textBoxUsuario.Text == string.Empty) { MessageBox.Show("Ingrese un usuario"); return true; }
            if (this.textBoxContrasena.Text == string.Empty) { MessageBox.Show("Ingrese una contraseña"); return true; }
            if (this.textBoxContrasenaVerificada.Text == string.Empty) { MessageBox.Show("Ingrese una contraseña"); return true; }
            if(this.textBoxContrasena.Text != this.textBoxContrasenaVerificada.Text) { MessageBox.Show("Las contraseñas no son las mismas"); return true; }
            else return false;
        }

    }
}
