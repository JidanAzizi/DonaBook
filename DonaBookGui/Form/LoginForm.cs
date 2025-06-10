using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using DonaBookApi.Model;
using DonaBookGui.Forms.Donatur;
using DonaBookGui.Forms.Penerima;
using DonaBookGui.Forms.Volunteer;
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

        // Event ketika tombol login diklik
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var loginData = new
            {
                Email = txtUsername.Text,
                Password = txtPassword.Text
            };

            var content = new StringContent(JsonSerializer.Serialize(loginData), Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync("api/user/login", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var user = JsonSerializer.Deserialize<User>(responseBody, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (user == null)
                    {
                        ShowError("Gagal memproses data login dari server.");
                        return;
                    }

                    Session.CurrentUser = user;
                    ShowInfo($"Login berhasil sebagai {user.Role}!");

                    OpenDashboardByRole(user);
                    this.Hide();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    ShowError("Login gagal: " + error);
                }
            }
            catch (Exception ex)
            {
                ShowError("Kesalahan koneksi: " + ex.Message);
            }
        }

        // Menampilkan dashboard sesuai role user
        private void OpenDashboardByRole(User user)
        {
            switch (user.Role.ToLower())
            {
                case "donatur":
                    new Donatur.Donatur(user).Show();
                    break;
                case "penerima":
                    new Penerima.Penerima().Show();
                    break;
                case "volunteer":
                    new VolunteerForm().Show();
                    break;
                default:
                    ShowError("Role tidak dikenali.");
                    break;
            }
        }

        // Tampilkan pesan error
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Tampilkan pesan informasi
        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Navigasi ke form registrasi
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }
    }
}
