using System;
using System.Windows.Forms;
using DonaBookGui.Services;

namespace DonaBookGui.Forms.Penerima
{
    public partial class Penerima : Form
    {
        public Penerima()
        {
            InitializeComponent();
            lblWelcome.Text = $"Selamat datang, {Session.CurrentUser?.Name} (Penerima)";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            new Auth.LoginForm().Show();
            this.Close();
        }
    }
}
