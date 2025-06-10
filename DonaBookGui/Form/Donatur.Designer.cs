namespace DonaBookGui.Forms.Donatur
{
    // Pastikan Anda berada di dalam namespace yang benar
    using System.Windows.Forms;

    partial class Donatur
    {
        private System.ComponentModel.IContainer components = null;

        // --- Kontrol Utama ---
        private Label lblWelcome;
        private Button btnLogout;
        private TabControl tabControlDonatur;

        // --- Tab 1: Donasi Buku ---
        private TabPage tabPageDonasi;
        private Label lblJudul, lblPenulis, lblPenerbit, lblJumlah;
        private TextBox txtJudul, txtPenulis, txtPenerbit;
        private NumericUpDown numJumlah;
        private GroupBox gbGenre, gbKategori, gbKondisi;
        private RadioButton rbGenreFiction, rbGenreHistory, rbGenreSelfHelp, rbGenreMystery; // Contoh
        private RadioButton rbKatAnakAnak, rbKatRemaja, rbKatDewasa;
        private RadioButton rbKondisiBaru, rbKondisiBekasBaik, rbKondisiBekasRusak;
        private Button btnSubmitDonasi;

        // --- Tab 2 & 3 ---
        private TabPage tabPageVerified, tabPageReviews;
        private DataGridView dgvVerifiedBooks, dgvReviews;
        private Button btnRefreshVerified, btnRefreshReviews;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnLogout = new Button();
            tabControlDonatur = new TabControl();
            tabPageDonasi = new TabPage();
            lblJudul = new Label();
            txtJudul = new TextBox();
            lblPenulis = new Label();
            txtPenulis = new TextBox();
            lblPenerbit = new Label();
            txtPenerbit = new TextBox();
            lblJumlah = new Label();
            numJumlah = new NumericUpDown();
            gbGenre = new GroupBox();
            rbGenreFiction = new RadioButton();
            rbGenreHistory = new RadioButton();
            rbGenreSelfHelp = new RadioButton();
            rbGenreMystery = new RadioButton();
            gbKategori = new GroupBox();
            rbKatAnakAnak = new RadioButton();
            rbKatRemaja = new RadioButton();
            rbKatDewasa = new RadioButton();
            gbKondisi = new GroupBox();
            rbKondisiBaru = new RadioButton();
            rbKondisiBekasBaik = new RadioButton();
            rbKondisiBekasRusak = new RadioButton();
            btnSubmitDonasi = new Button();
            tabPageVerified = new TabPage();
            dgvVerifiedBooks = new DataGridView();
            btnRefreshVerified = new Button();
            tabPageReviews = new TabPage();
            dgvReviews = new DataGridView();
            btnRefreshReviews = new Button();
            tabControlDonatur.SuspendLayout();
            tabPageDonasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            gbGenre.SuspendLayout();
            gbKategori.SuspendLayout();
            gbKondisi.SuspendLayout();
            tabPageVerified.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVerifiedBooks).BeginInit();
            tabPageReviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 25);
            lblWelcome.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(870, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // tabControlDonatur
            // 
            tabControlDonatur.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlDonatur.Controls.Add(tabPageDonasi);
            tabControlDonatur.Controls.Add(tabPageVerified);
            tabControlDonatur.Controls.Add(tabPageReviews);
            tabControlDonatur.Location = new Point(12, 50);
            tabControlDonatur.Name = "tabControlDonatur";
            tabControlDonatur.SelectedIndex = 0;
            tabControlDonatur.Size = new Size(960, 580);
            tabControlDonatur.TabIndex = 0;
            // 
            // tabPageDonasi
            // 
            tabPageDonasi.Controls.Add(lblJudul);
            tabPageDonasi.Controls.Add(txtJudul);
            tabPageDonasi.Controls.Add(lblPenulis);
            tabPageDonasi.Controls.Add(txtPenulis);
            tabPageDonasi.Controls.Add(lblPenerbit);
            tabPageDonasi.Controls.Add(txtPenerbit);
            tabPageDonasi.Controls.Add(lblJumlah);
            tabPageDonasi.Controls.Add(numJumlah);
            tabPageDonasi.Controls.Add(gbGenre);
            tabPageDonasi.Controls.Add(gbKategori);
            tabPageDonasi.Controls.Add(gbKondisi);
            tabPageDonasi.Controls.Add(btnSubmitDonasi);
            tabPageDonasi.Location = new Point(4, 24);
            tabPageDonasi.Name = "tabPageDonasi";
            tabPageDonasi.Padding = new Padding(10);
            tabPageDonasi.Size = new Size(952, 552);
            tabPageDonasi.TabIndex = 0;
            tabPageDonasi.Text = "Donasi Buku Baru";
            // 
            // lblJudul
            // 
            lblJudul.Location = new Point(20, 23);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(100, 23);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Judul:";
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(120, 20);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(400, 23);
            txtJudul.TabIndex = 1;
            // 
            // lblPenulis
            // 
            lblPenulis.Location = new Point(20, 63);
            lblPenulis.Name = "lblPenulis";
            lblPenulis.Size = new Size(100, 23);
            lblPenulis.TabIndex = 2;
            lblPenulis.Text = "Penulis:";
            // 
            // txtPenulis
            // 
            txtPenulis.Location = new Point(120, 60);
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new Size(400, 23);
            txtPenulis.TabIndex = 3;
            // 
            // lblPenerbit
            // 
            lblPenerbit.Location = new Point(20, 103);
            lblPenerbit.Name = "lblPenerbit";
            lblPenerbit.Size = new Size(100, 23);
            lblPenerbit.TabIndex = 4;
            lblPenerbit.Text = "Penerbit:";
            // 
            // txtPenerbit
            // 
            txtPenerbit.Location = new Point(120, 100);
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.Size = new Size(400, 23);
            txtPenerbit.TabIndex = 5;
            // 
            // lblJumlah
            // 
            lblJumlah.Location = new Point(20, 143);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(100, 23);
            lblJumlah.TabIndex = 6;
            lblJumlah.Text = "Jumlah:";
            // 
            // numJumlah
            // 
            numJumlah.Location = new Point(120, 140);
            numJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(120, 23);
            numJumlah.TabIndex = 7;
            numJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gbGenre
            // 
            gbGenre.Controls.Add(rbGenreFiction);
            gbGenre.Controls.Add(rbGenreHistory);
            gbGenre.Controls.Add(rbGenreSelfHelp);
            gbGenre.Controls.Add(rbGenreMystery);
            gbGenre.Location = new Point(20, 180);
            gbGenre.Name = "gbGenre";
            gbGenre.Size = new Size(500, 60);
            gbGenre.TabIndex = 8;
            gbGenre.TabStop = false;
            gbGenre.Text = "Pilih Genre";
            // 
            // rbGenreFiction
            // 
            rbGenreFiction.AutoSize = true;
            rbGenreFiction.Location = new Point(10, 25);
            rbGenreFiction.Name = "rbGenreFiction";
            rbGenreFiction.Size = new Size(61, 19);
            rbGenreFiction.TabIndex = 0;
            rbGenreFiction.Text = "Fiction";
            // 
            // rbGenreHistory
            // 
            rbGenreHistory.AutoSize = true;
            rbGenreHistory.Location = new Point(110, 25);
            rbGenreHistory.Name = "rbGenreHistory";
            rbGenreHistory.Size = new Size(63, 19);
            rbGenreHistory.TabIndex = 1;
            rbGenreHistory.Text = "History";
            // 
            // rbGenreSelfHelp
            // 
            rbGenreSelfHelp.AutoSize = true;
            rbGenreSelfHelp.Location = new Point(210, 25);
            rbGenreSelfHelp.Name = "rbGenreSelfHelp";
            rbGenreSelfHelp.Size = new Size(69, 19);
            rbGenreSelfHelp.TabIndex = 2;
            rbGenreSelfHelp.Text = "SelfHelp";
            // 
            // rbGenreMystery
            // 
            rbGenreMystery.AutoSize = true;
            rbGenreMystery.Location = new Point(320, 25);
            rbGenreMystery.Name = "rbGenreMystery";
            rbGenreMystery.Size = new Size(67, 19);
            rbGenreMystery.TabIndex = 3;
            rbGenreMystery.Text = "Mystery";
            // 
            // gbKategori
            // 
            gbKategori.Controls.Add(rbKatAnakAnak);
            gbKategori.Controls.Add(rbKatRemaja);
            gbKategori.Controls.Add(rbKatDewasa);
            gbKategori.Location = new Point(20, 250);
            gbKategori.Name = "gbKategori";
            gbKategori.Size = new Size(500, 60);
            gbKategori.TabIndex = 9;
            gbKategori.TabStop = false;
            gbKategori.Text = "Pilih Kategori";
            // 
            // rbKatAnakAnak
            // 
            rbKatAnakAnak.AutoSize = true;
            rbKatAnakAnak.Location = new Point(10, 25);
            rbKatAnakAnak.Name = "rbKatAnakAnak";
            rbKatAnakAnak.Size = new Size(79, 19);
            rbKatAnakAnak.TabIndex = 0;
            rbKatAnakAnak.Text = "AnakAnak";
            // 
            // rbKatRemaja
            // 
            rbKatRemaja.AutoSize = true;
            rbKatRemaja.Location = new Point(120, 25);
            rbKatRemaja.Name = "rbKatRemaja";
            rbKatRemaja.Size = new Size(64, 19);
            rbKatRemaja.TabIndex = 1;
            rbKatRemaja.Text = "Remaja";
            // 
            // rbKatDewasa
            // 
            rbKatDewasa.AutoSize = true;
            rbKatDewasa.Location = new Point(230, 25);
            rbKatDewasa.Name = "rbKatDewasa";
            rbKatDewasa.Size = new Size(65, 19);
            rbKatDewasa.TabIndex = 2;
            rbKatDewasa.Text = "Dewasa";
            // 
            // gbKondisi
            // 
            gbKondisi.Controls.Add(rbKondisiBaru);
            gbKondisi.Controls.Add(rbKondisiBekasBaik);
            gbKondisi.Controls.Add(rbKondisiBekasRusak);
            gbKondisi.Location = new Point(20, 320);
            gbKondisi.Name = "gbKondisi";
            gbKondisi.Size = new Size(500, 60);
            gbKondisi.TabIndex = 10;
            gbKondisi.TabStop = false;
            gbKondisi.Text = "Pilih Kondisi";
            // 
            // rbKondisiBaru
            // 
            rbKondisiBaru.AutoSize = true;
            rbKondisiBaru.Location = new Point(10, 25);
            rbKondisiBaru.Name = "rbKondisiBaru";
            rbKondisiBaru.Size = new Size(49, 19);
            rbKondisiBaru.TabIndex = 0;
            rbKondisiBaru.Text = "Baru";
            // 
            // rbKondisiBekasBaik
            // 
            rbKondisiBekasBaik.AutoSize = true;
            rbKondisiBekasBaik.Location = new Point(120, 25);
            rbKondisiBekasBaik.Name = "rbKondisiBekasBaik";
            rbKondisiBekasBaik.Size = new Size(77, 19);
            rbKondisiBekasBaik.TabIndex = 1;
            rbKondisiBekasBaik.Text = "BekasBaik";
            // 
            // rbKondisiBekasRusak
            // 
            rbKondisiBekasRusak.AutoSize = true;
            rbKondisiBekasRusak.Location = new Point(230, 25);
            rbKondisiBekasRusak.Name = "rbKondisiBekasRusak";
            rbKondisiBekasRusak.Size = new Size(86, 19);
            rbKondisiBekasRusak.TabIndex = 2;
            rbKondisiBekasRusak.Text = "BekasRusak";
            // 
            // btnSubmitDonasi
            // 
            btnSubmitDonasi.Location = new Point(20, 400);
            btnSubmitDonasi.Name = "btnSubmitDonasi";
            btnSubmitDonasi.Size = new Size(500, 40);
            btnSubmitDonasi.TabIndex = 11;
            btnSubmitDonasi.Text = "Ajukan Donasi";
            btnSubmitDonasi.Click += btnSubmitDonasi_Click;
            // 
            // tabPageVerified
            // 
            tabPageVerified.Controls.Add(dgvVerifiedBooks);
            tabPageVerified.Controls.Add(btnRefreshVerified);
            tabPageVerified.Location = new Point(4, 24);
            tabPageVerified.Name = "tabPageVerified";
            tabPageVerified.Size = new Size(952, 552);
            tabPageVerified.TabIndex = 1;
            tabPageVerified.Text = "Buku Terverifikasi";
            // 
            // dgvVerifiedBooks
            // 
            dgvVerifiedBooks.AllowUserToAddRows = false;
            dgvVerifiedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerifiedBooks.Dock = DockStyle.Fill;
            dgvVerifiedBooks.Location = new Point(0, 40);
            dgvVerifiedBooks.Name = "dgvVerifiedBooks";
            dgvVerifiedBooks.ReadOnly = true;
            dgvVerifiedBooks.Size = new Size(952, 512);
            dgvVerifiedBooks.TabIndex = 0;
            // 
            // btnRefreshVerified
            // 
            btnRefreshVerified.Dock = DockStyle.Top;
            btnRefreshVerified.Location = new Point(0, 0);
            btnRefreshVerified.Name = "btnRefreshVerified";
            btnRefreshVerified.Size = new Size(952, 40);
            btnRefreshVerified.TabIndex = 1;
            btnRefreshVerified.Text = "Muat Ulang Data";
            btnRefreshVerified.Click += btnRefreshVerified_Click;
            // 
            // tabPageReviews
            // 
            tabPageReviews.Controls.Add(dgvReviews);
            tabPageReviews.Controls.Add(btnRefreshReviews);
            tabPageReviews.Location = new Point(4, 24);
            tabPageReviews.Name = "tabPageReviews";
            tabPageReviews.Size = new Size(952, 552);
            tabPageReviews.TabIndex = 2;
            tabPageReviews.Text = "Lihat Review";
            // 
            // dgvReviews
            // 
            dgvReviews.AllowUserToAddRows = false;
            dgvReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReviews.Dock = DockStyle.Fill;
            dgvReviews.Location = new Point(0, 40);
            dgvReviews.Name = "dgvReviews";
            dgvReviews.ReadOnly = true;
            dgvReviews.RowTemplate.Height = 40;
            dgvReviews.Size = new Size(952, 512);
            dgvReviews.TabIndex = 0;
            // 
            // btnRefreshReviews
            // 
            btnRefreshReviews.Dock = DockStyle.Top;
            btnRefreshReviews.Location = new Point(0, 0);
            btnRefreshReviews.Name = "btnRefreshReviews";
            btnRefreshReviews.Size = new Size(952, 40);
            btnRefreshReviews.TabIndex = 1;
            btnRefreshReviews.Text = "Muat Ulang Data";
            btnRefreshReviews.Click += btnRefreshReviews_Click;
            // 
            // Donatur
            // 
            ClientSize = new Size(984, 641);
            Controls.Add(tabControlDonatur);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Name = "Donatur";
            Text = "Dashboard Donatur";
            Load += Donatur_Load;
            tabControlDonatur.ResumeLayout(false);
            tabPageDonasi.ResumeLayout(false);
            tabPageDonasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            gbGenre.ResumeLayout(false);
            gbGenre.PerformLayout();
            gbKategori.ResumeLayout(false);
            gbKategori.PerformLayout();
            gbKondisi.ResumeLayout(false);
            gbKondisi.PerformLayout();
            tabPageVerified.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVerifiedBooks).EndInit();
            tabPageReviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReviews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}