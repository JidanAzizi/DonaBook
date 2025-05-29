using System;
using System.Windows.Forms;

namespace DonaBookGui.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Ambil input user
            string namaLengkap = txtNamaLengkap.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string konfirmasiPassword = txtKonfirmasiPassword.Text;

            // Validasi sederhana
            if (string.IsNullOrEmpty(namaLengkap) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(konfirmasiPassword))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != konfirmasiPassword)
            {
                MessageBox.Show("Password dan konfirmasi password tidak cocok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan user ke database (nanti kamu bisa ganti bagian ini)
            MessageBox.Show("Registrasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Arahkan kembali ke login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
