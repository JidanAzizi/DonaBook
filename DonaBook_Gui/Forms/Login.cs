using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using DonaBook_Gui.Forms;
using DonaBook_Gui.Models;

namespace DonaBook_Gui.Forms
{
    public partial class Login : System.Windows.Forms.Form
    {
        private List<User> users;

        public Login()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!IsValidInput(username, password))
                return;

            if (!File.Exists(UserFilePath))
            {
                MessageBox.Show("File Users.json tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");

                if (!File.Exists(path))
                {
                    MessageBox.Show("File users.json tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    users = new List<User>();
                    return;
                }

                string json = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<User>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membaca file JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                users = new List<User>();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUser = txtUsername.Text.Trim();
            string inputPass = txtPassword.Text.Trim();

            User loginUser = users.Find(u => u.username == inputUser && u.password == inputPass);

            if (loginUser != null)
            {
                MessageBox.Show($"Login berhasil sebagai {loginUser.role}.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                if (loginUser.role == "donatur")
                {
                    var donaturForm = new FormDonatur();
                    donaturForm.FormClosed += (s, args) => this.Close();
                    donaturForm.Show();
                }
                else if (loginUser.role == "penerima")
                {
                    var penerimaForm = new FormPenerima();
                    penerimaForm.FormClosed += (s, args) => this.Close();
                    penerimaForm.Show();
                }
                else
                {
                    MessageBox.Show("Role tidak dikenali.");
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
