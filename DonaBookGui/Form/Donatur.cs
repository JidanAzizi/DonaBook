using System;
using System.Windows.Forms;
using DonaBookGui.Services;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.ResponseCaching;
using DonaBookApi.Controllers;
using DonaBookApi.Model;
using DonaBookApi.Services;

namespace DonaBookGui.Forms.Donatur
{
    public partial class Donatur : Form
    {
        public Donatur()
        {
            InitializeComponent();
            lblWelcome.Text = $"Selamat datang, {Session.CurrentUser?.Name} (Donatur)";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            new Auth.LoginForm().Show();
            this.Close();
        }

        private void categoryButtonGroupAnak(object sender, EventArgs e)
        {
            if (anakAnakButtonCat.Checked)
            {
                remajaButtonCat.Checked = false;
                dewasaButtonCat.Checked = false;
            }
        }

        private void categoryButtonGroupRemaja(object sender, EventArgs e)
        {
            if (remajaButtonCat.Checked)
            {
                anakAnakButtonCat.Checked = false;
                dewasaButtonCat.Checked = false;
            }
        }

        private void categoryButtonGroupDewasa(object sender, EventArgs e)
        {
            if (dewasaButtonCat.Checked)
            {
                anakAnakButtonCat.Checked = false;
                remajaButtonCat.Checked = false;
            }
        }

        private void stateButtonGroupSubmitted(object sender, EventArgs e)
        {
            if (submittedButtonState.Checked)
            {
                draftButtonState.Checked = false;
                verifiedButtonState.Checked = false;
                rejectedButtonState.Checked = false;
            }
        }

        private void stateButtonGroupDraft(object sender, EventArgs e)
        {
            if (draftButtonState.Checked)
            {
                submittedButtonState.Checked = false;
                verifiedButtonState.Checked = false;
                rejectedButtonState.Checked = false;
            }
        }

        private void stateButtonGroupVerified(object sender, EventArgs e)
        {
            if (verifiedButtonState.Checked)
            {
                draftButtonState.Checked = false;
                submittedButtonState.Checked = false;
                rejectedButtonState.Checked = false;
            }
        }

        private void stateButtonGroupRejected(object sender, EventArgs e)
        {
            if (rejectedButtonState.Checked)
            {
                draftButtonState.Checked = false;
                submittedButtonState.Checked = false;
                verifiedButtonState.Checked = false;
            }
        }
        private void conditionButtonGroupBaru(object sender, EventArgs e)
        {

            if (baruButtonCondition.Checked)
            {
                bekasBaikButtonCondition.Checked = false;
                bekasRusakButtonCondition.Checked = false;
            }
        }

        private void conditionButtonGroupBekasBaik(object sender, EventArgs e)
        {
            if (bekasBaikButtonCondition.Checked)
            {
                baruButtonCondition.Checked = false;
                bekasRusakButtonCondition.Checked = false;
            }
        }

        private void conditionButtonGroupBekasRusak(object sender, EventArgs e)
        {
            if (bekasRusakButtonCondition.Checked)
            {
                baruButtonCondition.Checked = false;
                bekasBaikButtonCondition.Checked = false;
            }
        }

        private void textboxJudulFitur1Text(object sender, EventArgs e)
        {

        }

        private async void btnSelesaiDonasiBuku(object sender, EventArgs e)
        {
            // Memvalidasi input untuk judul tidak boleh kosong.
            if (string.IsNullOrWhiteSpace(textboxJudulFitur1.Text))
            {
                MessageBox.Show("Judul buku tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textboxJudulFitur1.Focus();
                return;
            }

            // Mengumpulkan data dari inputan user.
            var judul = textboxJudulFitur1.Text.Trim();
            var penulis = textboxPenulisFitur1.Text.Trim();
            var genre = GetSelectedGenres();
            var kategori = anakAnakButtonCat.Checked ? "Anak" :
                           remajaButtonCat.Checked ? "Remaja" :
                           dewasaButtonCat.Checked ? "Dewasa" : "";
            var kondisi = baruButtonCondition.Checked ? "Baru" :
                            bekasBaikButtonCondition.Checked ? "Bekas Baik" :
                            bekasRusakButtonCondition.Checked ? "Bekas Rusak" : "";
            var state = draftButtonState.Checked ? "Draft" :
                        submittedButtonState.Checked ? "Submitted" :
                        verifiedButtonState.Checked ? "Verified" :
                        rejectedButtonState.Checked ? "Rejected" : "";

            // Validasi field lain.
            if (string.IsNullOrEmpty(kategori) || string.IsNullOrEmpty(kondisi) || string.IsNullOrEmpty(state))
            {
                MessageBox.Show("Mohon lengkapi semua kategori, kondisi, dan status buku.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bookData = new
            {
                Judul = judul,
                Penulis = penulis,
                Genre = genre,
                Kategori = kategori,
                Kondisi = kondisi,
                State = state,
            };

            try
            {
                using var client = new HttpClient();
                var response = await client.PostAsJsonAsync("http://localhost:5141/api/Book", bookData);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetDonasiForm();
                }
                else
                {
                    MessageBox.Show("Gagal mengirim data. Pastikan semua field terisi dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengirim data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method untuk menambahkan List genre.
        private List<string> GetSelectedGenres() {
            var genres = new List<string>();
            if (fictionLabelGenre.Checked) genres.Add("Fiction");
            if (nonFictionLabelGenre.Checked) genres.Add("NonFiction");
            if (scienceFictionLabelGenre.Checked) genres.Add("ScienceFiction");
            if (fantasyLabelGenre.Checked) genres.Add("Fantasy");
            if (mysteryLabelGenre.Checked) genres.Add("Mystery");
            if (romanceLabelGenre.Checked) genres.Add("Romance");
            if (biographyLabelGenre.Checked) genres.Add("Biography");
            if (horrorLabelGenre.Checked) genres.Add("Horror");
            if (historyLabelGenre.Checked) genres.Add("History");
            if (selfHelpLabelGenre.Checked) genres.Add("SelfHelp");
            if (unknownLabelGenre.Checked) genres.Add("Unknown");
            return genres;
        }

        // Reset form untuk fitur donasi.
        private void ResetDonasiForm() { 
            textboxJudulFitur1.Text = "";
            textboxPenulisFitur1.Text = "";

            fictionLabelGenre.Checked = false;
            nonFictionLabelGenre.Checked = false;
            scienceFictionLabelGenre.Checked = false;
            fantasyLabelGenre.Checked = false;
            mysteryLabelGenre.Checked = false;
            romanceLabelGenre.Checked = false;
            horrorLabelGenre.Checked = false;
            biographyLabelGenre.Checked = false;
            selfHelpLabelGenre.Checked = false;
            historyLabelGenre.Checked = false;
            unknownLabelGenre.Checked = false;

            anakAnakButtonCat.Checked = false;
            remajaButtonCat.Checked = false;
            dewasaButtonCat.Checked = false;

            baruButtonCondition.Checked = false;
            bekasBaikButtonCondition.Checked = false;
            bekasRusakButtonCondition.Checked = false;

            draftButtonState.Checked = false;
            submittedButtonState.Checked = false;
            verifiedButtonState.Checked = false;
            rejectedButtonState.Checked = false;
        }
    }
}
