using System;
using System.Windows.Forms;
using System.Linq;
using DonaBookClient.Services;
using DonaBookClient.Models;
using System.Linq.Expressions;
using DonaBookGui.Services;

namespace DonaBookGui.Forms.Volunteer
{
    public partial class VolunteerForm : Form
    {
        private readonly BookApiService _bookService;

        public VolunteerForm()
        {
            InitializeComponent();
            _bookService = new BookApiService();
            lblWelcome.Text = $"Selamat datang, {Session.CurrentUser?.Name} (Volunteer)";
            btnVerify.Click += BtnVerify_Click;
            btnVerify.Enabled = false;
            dgvPendingBooks.SelectionChanged += (s, e) =>
            {
                btnVerify.Enabled = dgvPendingBooks.SelectedRows.Count > 0;
            };
            LoadData();
        }

        private void InitializeCustomComponents() { /* Kosong, semua di Designer */ }

        private async void LoadData()
        {
            try
            {
                var allBooks = await _bookService.GetAllBooksAsync();
                var pendingBooks = allBooks.Where(b => !b.IsVerified).ToList();
                var verifiedBooks = allBooks.Where(b => b.IsVerified).ToList();

                // Load pending books
                dgvPendingBooks.Rows.Clear();
                foreach (var book in pendingBooks)
                {
                    dgvPendingBooks.Rows.Add(book.Id, book.Title, book.Author, book.Quantity, book.State);
                }

                // Load verified books
                dgvVerifiedBooks.Rows.Clear();
                foreach (var book in verifiedBooks)
                {
                    dgvVerifiedBooks.Rows.Add(book.Title, book.Author, book.Quantity);
                }

                // Update report
                lblTotalBooks.Text = $"Total Buku: {allBooks.Count}";
                lblVerifiedBooks.Text = $"Buku Terverifikasi: {verifiedBooks.Count}";
                lblUnverifiedBooks.Text = $"Buku Belum Verifikasi: {pendingBooks.Count}";
                lblTotalDonated.Text = $"Total Donasi Buku: {allBooks.Sum(b => b.Quantity)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnVerify_Click(object sender, EventArgs e)
        {
            if (dgvPendingBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris buku terlebih dahulu sebelum verifikasi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvPendingBooks.SelectedRows[0];
            int bookId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string bookTitle = selectedRow.Cells["Title"].Value?.ToString() ?? "";
            string bookAuthor = selectedRow.Cells["Author"].Value?.ToString() ?? "";

            var confirm = MessageBox.Show($"Apakah Anda yakin ingin memverifikasi buku berikut?\n\nJudul: {bookTitle}\nPenulis: {bookAuthor}", "Konfirmasi Verifikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var success = await _bookService.VerifyBookAsync(bookId);
                if (success)
                {
                    MessageBox.Show($"Buku berhasil diverifikasi!\n\nJudul: {bookTitle}\nPenulis: {bookAuthor}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Gagal memverifikasi buku:\n\nJudul: {bookTitle}\nPenulis: {bookAuthor}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            new Auth.LoginForm().Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VolunteerForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
