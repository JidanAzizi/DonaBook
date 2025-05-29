using System;
using System.Windows.Forms;

namespace DonaBookGui.Forms.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Implementasi logika login
            // Contoh: Validasi input
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Contoh: Panggil service otentikasi
            // bool isAuthenticated = AuthenticationService.Login(txtUsername.Text, txtPassword.Text);
            // if (isAuthenticated)
            // {
            //    MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    // Buka form utama
            //    MainForm mainForm = new MainForm();
            //    mainForm.Show();
            //    this.Hide(); // atau this.Close();
            // }
            // else
            // {
            //    MessageBox.Show("Username atau Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }

            MessageBox.Show($"Login attempt with Username: {txtUsername.Text}", "Login Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Untuk sekarang, kita tutup saja form loginnya sebagai placeholder
            // this.Close(); 
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Buka form register
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // Tampilkan sebagai dialog agar fokus
            // Atau, jika Anda ingin menutup login form dan membuka register:
            // this.Hide();
            // registerForm.Show();
            // registerForm.FormClosed += (s, args) => this.Close(); // Tutup login form jika register ditutup
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}