using System;
using System.Windows.Forms;

using System.Data;

namespace CapaPresentacion
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonEmpleado_Click(object sender, EventArgs e)
        {
            Forms.FormEmpleado formEmpleado = new Forms.FormEmpleado();
            formEmpleado.Show();
        }

        private void buttonSala_Click(object sender, EventArgs e)
        {
            Forms.FormSala formSala = new Forms.FormSala();
            formSala.Show();
        }

        private void buttonVentaDulceria_Click(object sender, EventArgs e)
        {
            Forms.FormVentaDulceria formVentaDulceria = new Forms.FormVentaDulceria();
            formVentaDulceria.Show();
        }

        private void buttonFuncion_Click(object sender, EventArgs e)
        {
            Forms.FormFuncion formFuncion = new Forms.FormFuncion();
            formFuncion.Show();
        }

        private void buttonArticulo_Click(object sender, EventArgs e)
        {
            Forms.FormArticulo articulo = new Forms.FormArticulo();
            articulo.Show();
        }

        private void buttonVentaTaquilla_Click(object sender, EventArgs e)
        {
            Forms.FormVentaTaquilla formVentaTaquilla = new Forms.FormVentaTaquilla();
            formVentaTaquilla.Show();
        }
    }
}
