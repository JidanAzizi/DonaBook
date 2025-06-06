namespace DonaBook_Gui.Forms
{
    partial class FormPenerima
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvDonasi;
        private System.Windows.Forms.TextBox txtCariJudul;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtNamaPenerima;
        private System.Windows.Forms.Button btnAjukanPermintaan;
        private System.Windows.Forms.TextBox txtUlasan;
        private System.Windows.Forms.Button btnBeriUlasan;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Label lblCariJudul;
        private System.Windows.Forms.Label lblNamaPenerima;
        private System.Windows.Forms.Label lblUlasan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvDonasi = new System.Windows.Forms.DataGridView();
            txtCariJudul = new System.Windows.Forms.TextBox();
            btnCari = new System.Windows.Forms.Button();
            txtNamaPenerima = new System.Windows.Forms.TextBox();
            btnAjukanPermintaan = new System.Windows.Forms.Button();
            txtUlasan = new System.Windows.Forms.TextBox();
            btnBeriUlasan = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();

            lblCariJudul = new System.Windows.Forms.Label();
            lblNamaPenerima = new System.Windows.Forms.Label();
            lblUlasan = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(dgvDonasi)).BeginInit();
            SuspendLayout();

            // dgvDonasi
            dgvDonasi.Location = new System.Drawing.Point(20, 60);
            dgvDonasi.Name = "dgvDonasi";
            dgvDonasi.Size = new System.Drawing.Size(600, 250);
            dgvDonasi.ReadOnly = true;
            dgvDonasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDonasi.MultiSelect = false;
            dgvDonasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // txtCariJudul
            txtCariJudul.Location = new System.Drawing.Point(100, 20);
            txtCariJudul.Name = "txtCariJudul";
            txtCariJudul.Size = new System.Drawing.Size(300, 26);

            // btnCari
            btnCari.Location = new System.Drawing.Point(420, 18);
            btnCari.Name = "btnCari";
            btnCari.Size = new System.Drawing.Size(75, 30);
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;

            // btnReset
            btnReset.Location = new System.Drawing.Point(510, 18);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(75, 30);
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;

            // lblCariJudul
            lblCariJudul.AutoSize = true;
            lblCariJudul.Location = new System.Drawing.Point(20, 23);
            lblCariJudul.Name = "lblCariJudul";
            lblCariJudul.Text = "Cari Judul";

            // txtNamaPenerima
            txtNamaPenerima.Location = new System.Drawing.Point(120, 330);
            txtNamaPenerima.Name = "txtNamaPenerima";
            txtNamaPenerima.Size = new System.Drawing.Size(200, 26);

            // lblNamaPenerima
            lblNamaPenerima.AutoSize = true;
            lblNamaPenerima.Location = new System.Drawing.Point(20, 333);
            lblNamaPenerima.Name = "lblNamaPenerima";
            lblNamaPenerima.Text = "Nama Penerima";

            // btnAjukanPermintaan
            btnAjukanPermintaan.Location = new System.Drawing.Point(340, 328);
            btnAjukanPermintaan.Name = "btnAjukanPermintaan";
            btnAjukanPermintaan.Size = new System.Drawing.Size(150, 30);
            btnAjukanPermintaan.Text = "Ajukan Permintaan";
            btnAjukanPermintaan.UseVisualStyleBackColor = true;
            btnAjukanPermintaan.Click += btnAjukanPermintaan_Click;

            // txtUlasan
            txtUlasan.Location = new System.Drawing.Point(120, 380);
            txtUlasan.Multiline = true;
            txtUlasan.Name = "txtUlasan";
            txtUlasan.Size = new System.Drawing.Size(370, 60);

            // lblUlasan
            lblUlasan.AutoSize = true;
            lblUlasan.Location = new System.Drawing.Point(20, 383);
            lblUlasan.Name = "lblUlasan";
            lblUlasan.Text = "Ulasan";

            // btnBeriUlasan
            btnBeriUlasan.Location = new System.Drawing.Point(510, 410);
            btnBeriUlasan.Name = "btnBeriUlasan";
            btnBeriUlasan.Size = new System.Drawing.Size(110, 30);
            btnBeriUlasan.Text = "Beri Ulasan";
            btnBeriUlasan.UseVisualStyleBackColor = true;
            btnBeriUlasan.Click += btnBeriUlasan_Click;

            // FormPenerima
            ClientSize = new System.Drawing.Size(650, 460);
            Controls.Add(dgvDonasi);
            Controls.Add(txtCariJudul);
            Controls.Add(btnCari);
            Controls.Add(btnReset);
            Controls.Add(lblCariJudul);
            Controls.Add(txtNamaPenerima);
            Controls.Add(lblNamaPenerima);
            Controls.Add(btnAjukanPermintaan);
            Controls.Add(txtUlasan);
            Controls.Add(lblUlasan);
            Controls.Add(btnBeriUlasan);

            Name = "FormPenerima";
            Text = "Form Penerima";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(dgvDonasi)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
