using System;
using System.Windows.Forms;

using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace DonaBookGui.Forms.Auth
{
    public partial class LoginForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5141/")
        };

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtUsername.Text;
            var password = txtPassword.Text;

            var loginData = new
            {
                Email = email,
                Password = password
            };

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

                    MessageBox.Show("Login berhasil!\nRedirect: " + loginResult.Redirect);
                    //tinggal masukin form dashboard sesuai role guys
                    // buka form sesuai role
                    // if (loginResult.Role == "donatur") new DonaturForm().Show(); (ini kayak nya pemanggilan suatu form nya oke aman lah ya cihuy rawrrrr krakatau)
                    // this.Hide();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Login gagal: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan koneksi: " + ex.Message);
            }
        }
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }


        private class LoginResult
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }
            public string Redirect { get; set; }
        }
    }
}
