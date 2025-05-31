using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

using DonaBookGui.Forms.Auth;
using DonaBookGui.Forms.Donatur;
using DonaBookGui.Forms.Penerima;
using DonaBookGui.Forms.Volunteer;
using DonaBookGui.Models;
using DonaBookGui.Services;

namespace DonaBookGui.Forms.Auth
{
    public partial class LoginForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5141/")
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtUsername.Text;
            var password = txtPassword.Text;

            var loginData = new { Email = email, Password = password };

            var json = JsonSerializer.Serialize(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync("api/user/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var loginResult = JsonSerializer.Deserialize<LoginResult>(responseBody, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });


                    Session.CurrentUser = loginResult;

                    MessageBox.Show($"Login berhasil sebagai {loginResult.Role}!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Buka form dashboard sesuai role
                    switch (loginResult.Role.ToLower())
                    {
                        case "donatur":
                            new Donatur.Donatur().Show();
                            break;
                        case "penerima":
                            new Penerima.Penerima().Show();
                            break;
                        case "volunteer":
                            new VolunteerForm().Show();
                            break;
                        default:
                            MessageBox.Show("Role tidak dikenali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    this.Hide();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Login gagal: " + error, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan koneksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
