using DonaBookApi.Model;
using DonaBookClient.Models;
using DonaBookClient.Services;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonaBookGui.Forms.Donatur
{
    public partial class Donatur : Form
    {
        private readonly BookApiService _bookService;
        private readonly User _loggedInUser;

        public Donatur(User user)
        {
            InitializeComponent();
            _bookService = new BookApiService();
            _loggedInUser = user;
        }

        // Menampilkan nama user.
        private async void Donatur_Load(object sender, EventArgs e)
        {
            if (_loggedInUser == null)
            {
                lblWelcome.Text = "Selamat datang, Tamu!";
                MessageBox.Show("Gagal memuat data pengguna.", "Error");
                return;
            }
            lblWelcome.Text = $"Selamat datang, {_loggedInUser.Name}!";

            // Panggil metode load yang sudah diperbaiki.
            SetupVerifiedBooksGrid();
            SetupReviewsGrid();

            await LoadVerifiedBooksAsync();
            await LoadReviewsAsync();
        }

        #region Konfigurasi Awal DataGridView

        // Mengatur kolom DataGridView.
        private void SetupVerifiedBooksGrid()
        {
            dgvVerifiedBooks.AutoGenerateColumns = false;
            dgvVerifiedBooks.Columns.Clear();

            dgvVerifiedBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });
            dgvVerifiedBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Judul",
                DataPropertyName = "Title",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvVerifiedBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Author",
                HeaderText = "Penulis",
                DataPropertyName = "Author",
                Width = 150
            });
            dgvVerifiedBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Genre",
                HeaderText = "Genre",
                DataPropertyName = "Genre",
                Width = 100
            });
        }

        // Mengatur tampilan kolom unutuk daftar review buku.
        private void SetupReviewsGrid()
        {
            dgvReviews.AutoGenerateColumns = false;
            dgvReviews.Columns.Clear();

            dgvReviews.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Judul Buku",
                DataPropertyName = "Title",
                Width = 200
            });
            dgvReviews.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Rating",
                HeaderText = "Rating",
                DataPropertyName = "Rating",
                Width = 60
            });
            dgvReviews.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Review",
                HeaderText = "Isi Review",
                DataPropertyName = "Review",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { WrapMode = DataGridViewTriState.True }
            });
            dgvReviews.RowTemplate.Height = 60;
        }

        #endregion

        #region Load Data Methods

        // Mengambil data buku yang sudah diverifikasi.
        private async Task LoadVerifiedBooksAsync()
        {
            try
            {
                btnRefreshVerified.Enabled = false;
                dgvVerifiedBooks.DataSource = null;
                var data = await _bookService.GetVerifiedBooksAsync();
                dgvVerifiedBooks.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat buku: {ex.Message}", "Error");
            }
            finally
            {
                btnRefreshVerified.Enabled = true;
            }
        }

        // Mengambil data buku dan review.
        private async Task LoadReviewsAsync()
        {
            try
            {
                btnRefreshReviews.Enabled = false;
                dgvReviews.DataSource = null;
                var data = await _bookService.GetBooksWithReviewsAsync();
                dgvReviews.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat review: {ex.Message}", "Error");
            }
            finally
            {
                btnRefreshReviews.Enabled = true;
            }
        }
        #endregion

        // Handlers untuk tombol-tombol.
        #region Event Handlers
        private void btnLogout_Click(object sender, EventArgs e) { this.Close(); }
        private async void btnRefreshVerified_Click(object sender, EventArgs e) { await LoadVerifiedBooksAsync(); }
        private async void btnRefreshReviews_Click(object sender, EventArgs e) { await LoadReviewsAsync(); }
        private async void btnSubmitDonasi_Click(object sender, EventArgs e)
        {
            if (!ValidateDonationForm()) return;
            var newBook = new Book { Title = txtJudul.Text.Trim(), Author = txtPenulis.Text.Trim(), Publisher = txtPenerbit.Text.Trim(), Quantity = (int)numJumlah.Value, IsVerified = false, Genre = Enum.Parse<Genre>(GetSelectedRadioButtonText(gbGenre), true), Category = Enum.Parse<Category>(GetSelectedRadioButtonText(gbKategori), true), Condition = Enum.Parse<BookCondition>(GetSelectedRadioButtonText(gbKondisi), true) };
            try
            {
                var createdBook = await _bookService.DonateBookAsync(newBook);
                if (createdBook != null)
                {
                    await _bookService.SubmitAsync(createdBook.Id);
                    MessageBox.Show("Buku berhasil didonasikan dan diajukan untuk verifikasi!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetDonasiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Helper Methods

        // Validasi form donasi buku.
        private bool ValidateDonationForm()
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text) || string.IsNullOrWhiteSpace(txtPenulis.Text) || string.IsNullOrWhiteSpace(txtPenerbit.Text))
            { MessageBox.Show("Judul, Penulis, dan Penerbit tidak boleh kosong.", "Peringatan"); return false; }
            if (string.IsNullOrEmpty(GetSelectedRadioButtonText(gbGenre)) || string.IsNullOrEmpty(GetSelectedRadioButtonText(gbKategori)) || string.IsNullOrEmpty(GetSelectedRadioButtonText(gbKondisi)))
            { MessageBox.Show("Silakan pilih Genre, Kategori, dan Kondisi.", "Peringatan"); return false; }
            return true;
        }

        // Mengambil teks dari RadioButton.
        private string GetSelectedRadioButtonText(GroupBox groupBox)
        { return groupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? string.Empty; }

        // Mengatur ulang form donasi buku.
        private void ResetDonasiForm()
        {
            txtJudul.Clear(); txtPenulis.Clear(); txtPenerbit.Clear();
            numJumlah.Value = 1;
            Action<GroupBox> uncheckRadioButtons = (gb) => { var rb = gb.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked); if (rb != null) rb.Checked = false; };
            uncheckRadioButtons(gbGenre);
            uncheckRadioButtons(gbKategori);
            uncheckRadioButtons(gbKondisi);
        }
        #endregion
    }
}