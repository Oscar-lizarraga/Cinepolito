using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }

        private void FormLogin_Shown(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
