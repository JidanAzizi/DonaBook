﻿namespace DonaBookGui.Forms.Volunteer
{
    // Inisialisasi komponen untuk kelas VolunteerForm.
    partial class VolunteerForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnLogout;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private System.Windows.Forms.Panel panelVerifikasi;
        private System.Windows.Forms.DataGridView dgvPendingBooks;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.DataGridView dgvVerifiedBooks;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblVerifiedBooks;
        private System.Windows.Forms.Label lblUnverifiedBooks;
        private System.Windows.Forms.Label lblTotalDonated;

        // Override metode Dispose untuk membersihkan resource yang digunakan oleh form.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // Implementasi metode Load untuk memuat data saat form dimuat.
        private void VolunteerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Inisialisasi komponen UI untuk form VolunteerForm.
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnLogout = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();

            // Atribut untuk label selamat datang.
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(226, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat datang, ...";

            // Atribut untuk tombol logout.
            btnLogout.Location = new Point(826, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;

            // Atribut untuk tab control yang berisi beberapa tab.
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 574);
            tabControl1.TabIndex = 5;

            // Atribut untuk tabPage1 (Verifikasi Buku).
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 541);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Verifikasi Buku";
            tabPage1.UseVisualStyleBackColor = true;

            // Inisialisasi panel untuk verifikasi buku.
            this.panelVerifikasi = new System.Windows.Forms.Panel();
            this.dgvPendingBooks = new System.Windows.Forms.DataGridView();
            this.btnVerify = new System.Windows.Forms.Button();

            // Atribut untuk panel verifikasi buku.
            this.panelVerifikasi.Location = new System.Drawing.Point(0, 0);
            this.panelVerifikasi.Size = new System.Drawing.Size(906, 541);
            this.panelVerifikasi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Atribut untuk DataGridView yang menampilkan buku yang perlu diverifikasi.
            this.dgvPendingBooks.Location = new System.Drawing.Point(20, 20);
            this.dgvPendingBooks.Size = new System.Drawing.Size(850, 400);
            this.dgvPendingBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingBooks.MultiSelect = false;
            this.dgvPendingBooks.AllowUserToAddRows = false;
            this.dgvPendingBooks.AllowUserToDeleteRows = false;
            this.dgvPendingBooks.ReadOnly = true;

            // Menambahkan kolom ke DataGridView untuk buku yang perlu diverifikasi.
            this.dgvPendingBooks.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn { Name = "Title", HeaderText = "Judul" },
                new DataGridViewTextBoxColumn { Name = "Author", HeaderText = "Penulis" },
                new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Jumlah" },
                new DataGridViewTextBoxColumn { Name = "State", HeaderText = "Status" }
            });

            // Atribut untuk tombol verifikasi buku.
            this.btnVerify.Text = "Verifikasi Buku Terpilih";
            this.btnVerify.Location = new System.Drawing.Point(20, 430);
            this.btnVerify.Size = new System.Drawing.Size(200, 30);
            this.btnVerify.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Menambahkan event handler untuk tombol verifikasi.
            this.panelVerifikasi.Controls.Add(this.dgvPendingBooks);
            this.panelVerifikasi.Controls.Add(this.btnVerify);

            // Menambahkan panel verifikasi ke tabPage1.
            this.tabPage1.Controls.Add(this.panelVerifikasi);

            // Atribut untuk tabPage2 (Buku Terverifikasi).
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buku Terverifikasi";
            tabPage2.UseVisualStyleBackColor = true;

            // Inisialisasi DataGridView untuk buku terverifikasi.
            this.dgvVerifiedBooks = new System.Windows.Forms.DataGridView();
            this.dgvVerifiedBooks.Location = new System.Drawing.Point(20, 20);
            this.dgvVerifiedBooks.Size = new System.Drawing.Size(850, 480);
            this.dgvVerifiedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerifiedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerifiedBooks.MultiSelect = false;
            this.dgvVerifiedBooks.AllowUserToAddRows = false;
            this.dgvVerifiedBooks.AllowUserToDeleteRows = false;
            this.dgvVerifiedBooks.ReadOnly = true;
            this.dgvVerifiedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Title", HeaderText = "Judul" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Author", HeaderText = "Penulis" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Jumlah" }
            });
            this.tabPage2.Controls.Add(this.dgvVerifiedBooks);

            // Atribut untuk tabPage3 (Laporan).
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(906, 541);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Laporan";
            tabPage3.UseVisualStyleBackColor = true;

            // Inisialisasi label untuk laporan.
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblVerifiedBooks = new System.Windows.Forms.Label();
            this.lblUnverifiedBooks = new System.Windows.Forms.Label();
            this.lblTotalDonated = new System.Windows.Forms.Label();

            // Atribut untuk label laporan.
            this.lblTotalBooks.Location = new System.Drawing.Point(20, 20);
            this.lblTotalBooks.Size = new System.Drawing.Size(300, 30);
            this.lblTotalBooks.Text = "Total Buku: 0";

            // Atribut untuk label buku terverifikasi.
            this.lblVerifiedBooks.Location = new System.Drawing.Point(20, 60);
            this.lblVerifiedBooks.Size = new System.Drawing.Size(300, 30);
            this.lblVerifiedBooks.Text = "Buku Terverifikasi: 0";

            // Atribut untuk label buku belum diverifikasi.
            this.lblUnverifiedBooks.Location = new System.Drawing.Point(20, 100);
            this.lblUnverifiedBooks.Size = new System.Drawing.Size(300, 30);
            this.lblUnverifiedBooks.Text = "Buku Belum Verifikasi: 0";

            // Atribut untuk label total donasi buku.
            this.lblTotalDonated.Location = new System.Drawing.Point(20, 140);
            this.lblTotalDonated.Size = new System.Drawing.Size(300, 30);
            this.lblTotalDonated.Text = "Total Donasi Buku: 0";

            // Menambahkan label laporan ke tabPage3.
            this.tabPage3.Controls.Add(this.lblTotalBooks);
            this.tabPage3.Controls.Add(this.lblVerifiedBooks);
            this.tabPage3.Controls.Add(this.lblUnverifiedBooks);
            this.tabPage3.Controls.Add(this.lblTotalDonated);

            // Atribut untuk form VolunteerForm.
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 692);
            Controls.Add(tabControl1);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Name = "VolunteerForm";
            Text = "Volunteer Dashboard";
            Load += VolunteerForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
