
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var loginData = new { Email = txtUsername.Text, Password = txtPassword.Text };
            var content = new StringContent(JsonSerializer.Serialize(loginData), Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync("api/user/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();

                    // --- INI BAGIAN UTAMA PERBAIKAN ---
                    // Tidak lagi Deserialize ke 'LoginResult', tapi langsung ke 'User'
                    var loggedInUser = JsonSerializer.Deserialize<User>(responseBody, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    // Pastikan user tidak null setelah deserialize
                    if (loggedInUser == null)
                    {
                        MessageBox.Show("Gagal memproses data login dari server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Session.CurrentUser = loggedInUser;
                    MessageBox.Show($"Login berhasil sebagai {loggedInUser.Role}!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Buka form dashboard sesuai role dan oper data 'loggedInUser'
                    switch (loggedInUser.Role.ToLower())
                    {
                        case "donatur":
                            // Panggilan ini sekarang valid karena tipe datanya sama (User)
                            new Donatur.Donatur(loggedInUser).Show();
                            break;
                        case "penerima":
                            // new Penerima.Penerima(loggedInUser).Show(); // Pastikan form Penerima juga sudah diperbaiki
                            break;
                        case "volunteer":
                            // new VolunteerForm(loggedInUser).Show(); // Pastikan form Volunteer juga sudah diperbaiki
                            break;
                        default:
                            MessageBox.Show("Role tidak dikenali.", "Error");
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

        private void LoginForm_Load(object sender, EventArgs e) { }
    }
}