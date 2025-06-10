using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonaBookGui.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private const string BaseUrl = "http://localhost:5141/";
        private const string RegisterEndpoint = "api/user/register";

        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(BaseUrl)
        };

        public RegisterForm()
        {
            InitializeComponent();
            ConfigurePasswordFields();
        }

        /// <summary>
        /// Atur tampilan input password agar tidak terlihat saat diketik.
        /// </summary>
        private void ConfigurePasswordFields()
        {
            txtPassword.UseSystemPasswordChar = true;
            txtKonfirmasiPassword.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Event ketika tombol Register diklik.
        /// </summary>
        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
                return;

            var userPayload = CreateUserPayload();
            var content = new StringContent(JsonSerializer.Serialize(userPayload), Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync(RegisterEndpoint, content);
                await HandleRegisterResponseAsync(response);
            }
            catch (Exception ex)
            {
                ShowError($"Kesalahan koneksi: {ex.Message}");
            }
        }

        /// <summary>
        /// Validasi seluruh input form.
        /// </summary>
        private bool IsFormValid()
        {
            if (!AreFieldsFilled())
            {
                ShowWarning("Semua field wajib diisi.");
                return false;
            }

            if (!IsValidEmail(txtUsername.Text))
            {
                ShowError("Format email tidak valid.");
                return false;
            }

            if (!IsValidPassword(txtPassword.Text))
            {
                ShowError("Password minimal 8 karakter.");
                return false;
            }

            if (txtPassword.Text != txtKonfirmasiPassword.Text)
            {
                ShowError("Password dan konfirmasi tidak cocok.");
                return false;
            }

            if (!IsDigitsOnly(txtKontak.Text))
            {
                ShowError("Kontak hanya boleh berisi angka.");
                return false;
            }

            if (cmbRole.SelectedItem == null)
            {
                ShowWarning("Silakan pilih role.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Pastikan semua field tidak kosong.
        /// </summary>
        private bool AreFieldsFilled()
        {
            return
                !string.IsNullOrWhiteSpace(txtNamaLengkap.Text) &&
                !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtKonfirmasiPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtAlamat.Text) &&
                !string.IsNullOrWhiteSpace(txtKontak.Text);
        }

        /// <summary>
        /// Validasi format email.
        /// </summary>
        private bool IsValidEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        /// <summary>
        /// Validasi panjang password minimal.
        /// </summary>
        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        /// <summary>
        /// Validasi agar kontak hanya angka.
        /// </summary>
        private bool IsDigitsOnly(string input) 
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        /// <summary>
        /// Buat payload untuk dikirim ke API.
        /// </summary>
        private object CreateUserPayload()
        {
            return new
            {
                Name = txtNamaLengkap.Text.Trim(),
                Email = txtUsername.Text.Trim().ToLower(),
                Password = txtPassword.Text,
                Address = txtAlamat.Text.Trim(),
                Contact = txtKontak.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString()
            };
        }

        /// <summary>
        /// Tangani response dari API setelah registrasi.
        /// </summary>
        private async Task HandleRegisterResponseAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                ShowInfo("Registrasi berhasil! Silakan login.");
                NavigateToLogin();
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                ShowError($"Registrasi gagal: {errorMessage}");
            }
        }

        /// <summary>
        /// Pindah ke form login.
        /// </summary>
        private void NavigateToLogin()
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateToLogin();
        }

        #region Message Helpers

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
