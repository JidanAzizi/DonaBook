namespace DonaBook_Gui.Forms
{
    partial class FormDonatur
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPenulis;
        private System.Windows.Forms.Label lblPenerbit;
        private System.Windows.Forms.Label lblTahun;

        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtTahun;

        private System.Windows.Forms.Button btnAjukan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSubmit;

        private System.Windows.Forms.DataGridView dgvDonasi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblJudul = new System.Windows.Forms.Label();
            lblPenulis = new System.Windows.Forms.Label();
            lblPenerbit = new System.Windows.Forms.Label();
            lblTahun = new System.Windows.Forms.Label();

            txtJudul = new System.Windows.Forms.TextBox();
            txtPenulis = new System.Windows.Forms.TextBox();
            txtPenerbit = new System.Windows.Forms.TextBox();
            txtTahun = new System.Windows.Forms.TextBox();

            btnAjukan = new System.Windows.Forms.Button();
            btnHapus = new System.Windows.Forms.Button();
            btnSubmit = new System.Windows.Forms.Button();

            dgvDonasi = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(dgvDonasi)).BeginInit();

            SuspendLayout();

            // lblJudul
            lblJudul.AutoSize = true;
            lblJudul.Location = new System.Drawing.Point(30, 30);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new System.Drawing.Size(47, 20);
            lblJudul.Text = "Judul";

            // txtJudul
            txtJudul.Location = new System.Drawing.Point(120, 27);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new System.Drawing.Size(200, 26);

            // lblPenulis
            lblPenulis.AutoSize = true;
            lblPenulis.Location = new System.Drawing.Point(30, 70);
            lblPenulis.Name = "lblPenulis";
            lblPenulis.Size = new System.Drawing.Size(52, 20);
            lblPenulis.Text = "Penulis";

            // txtPenulis
            txtPenulis.Location = new System.Drawing.Point(120, 67);
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new System.Drawing.Size(200, 26);

            // lblPenerbit
            lblPenerbit.AutoSize = true;
            lblPenerbit.Location = new System.Drawing.Point(30, 110);
            lblPenerbit.Name = "lblPenerbit";
            lblPenerbit.Size = new System.Drawing.Size(62, 20);
            lblPenerbit.Text = "Penerbit";

            // txtPenerbit
            txtPenerbit.Location = new System.Drawing.Point(120, 107);
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.Size = new System.Drawing.Size(200, 26);

            // lblTahun
            lblTahun.AutoSize = true;
            lblTahun.Location = new System.Drawing.Point(30, 150);
            lblTahun.Name = "lblTahun";
            lblTahun.Size = new System.Drawing.Size(48, 20);
            lblTahun.Text = "Tahun";

            // txtTahun
            txtTahun.Location = new System.Drawing.Point(120, 147);
            txtTahun.Name = "txtTahun";
            txtTahun.Size = new System.Drawing.Size(200, 26);

            // btnAjukan
            btnAjukan.Location = new System.Drawing.Point(350, 25);
            btnAjukan.Name = "btnAjukan";
            btnAjukan.Size = new System.Drawing.Size(100, 30);
            btnAjukan.Text = "Ajukan";
            btnAjukan.UseVisualStyleBackColor = true;
            btnAjukan.Click += btnAjukan_Click;

            // btnHapus
            btnHapus.Location = new System.Drawing.Point(350, 65);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new System.Drawing.Size(100, 30);
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;

            // btnSubmit
            btnSubmit.Location = new System.Drawing.Point(350, 105);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(100, 30);
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;

            // dgvDonasi
            dgvDonasi.Location = new System.Drawing.Point(30, 190);
            dgvDonasi.Name = "dgvDonasi";
            dgvDonasi.Size = new System.Drawing.Size(600, 230);
            dgvDonasi.ReadOnly = true;
            dgvDonasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDonasi.MultiSelect = false;
            dgvDonasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // FormDonatur
            ClientSize = new System.Drawing.Size(660, 450);
            Controls.Add(lblJudul);
            Controls.Add(txtJudul);
            Controls.Add(lblPenulis);
            Controls.Add(txtPenulis);
            Controls.Add(lblPenerbit);
            Controls.Add(txtPenerbit);
            Controls.Add(lblTahun);
            Controls.Add(txtTahun);
            Controls.Add(btnAjukan);
            Controls.Add(btnHapus);
            Controls.Add(btnSubmit);
            Controls.Add(dgvDonasi);
            Name = "FormDonatur";
            Text = "Form Donatur";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(dgvDonasi)).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
