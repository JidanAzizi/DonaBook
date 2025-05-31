using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace DonaBookGui.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5141/") 
        };

        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtKonfirmasiPassword.Text)
            {
                MessageBox.Show("Password dan konfirmasi tidak cocok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = new
            {
                Name = txtNamaLengkap.Text,
                Email = txtUsername.Text,
                Password = txtPassword.Text,
                Address = txtAlamat.Text,
                Contact = txtKontak.Text,
                Role = cmbRole.SelectedItem.ToString()
            };

            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync("api/user/register", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new LoginForm().Show();
                    this.Hide();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Registrasi gagal: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan koneksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
