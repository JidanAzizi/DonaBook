using System;
using System.Windows.Forms;
using DonaBookGui.Services;

namespace DonaBookGui.Forms.Volunteer
{
    public partial class VolunteerForm : Form
    {
        public VolunteerForm()
        {
            InitializeComponent();
            lblWelcome.Text = $"Selamat datang, {Session.CurrentUser?.Name} (Volunteer)";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            new Auth.LoginForm().Show();
            this.Close();
        }
    }
}
