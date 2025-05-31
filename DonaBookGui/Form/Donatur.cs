using System;
using System.Windows.Forms;
using DonaBookGui.Services;

namespace DonaBookGui.Forms.Donatur
{
    public partial class Donatur : Form
    {
        public Donatur()
        {
            InitializeComponent();
            lblWelcome.Text = $"Selamat datang, {Session.CurrentUser?.Name} (Donatur)";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            new Auth.LoginForm().Show();
            this.Close();
        }
    }
}
