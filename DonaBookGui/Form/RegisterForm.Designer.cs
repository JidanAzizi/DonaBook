namespace DonaBookGui.Forms.Auth
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblNamaLengkap = new Label();
            txtNamaLengkap = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblKonfirmasiPassword = new Label();
            txtKonfirmasiPassword = new TextBox();
            lblAlamat = new Label();
            txtAlamat = new TextBox();
            lblKontak = new Label();
            txtKontak = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            lnkLogin = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.Location = new Point(95, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BUAT AKUN BARU";
            // 
            // lblNamaLengkap
            // 
            lblNamaLengkap.AutoSize = true;
            lblNamaLengkap.Location = new Point(40, 70);
            lblNamaLengkap.Name = "lblNamaLengkap";
            lblNamaLengkap.Size = new Size(87, 15);
            lblNamaLengkap.TabIndex = 1;
            lblNamaLengkap.Text = "Nama Lengkap";
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Location = new Point(40, 90);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(300, 23);
            txtNamaLengkap.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(40, 130);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(40, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(40, 190);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 6;
            // 
            // lblKonfirmasiPassword
            // 
            lblKonfirmasiPassword.Location = new Point(40, 250);
            lblKonfirmasiPassword.Name = "lblKonfirmasiPassword";
            lblKonfirmasiPassword.Size = new Size(100, 23);
            lblKonfirmasiPassword.TabIndex = 7;
            lblKonfirmasiPassword.Text = "Konfirmasi Password";
            // 
            // txtKonfirmasiPassword
            // 
            txtKonfirmasiPassword.Location = new Point(40, 270);
            txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
            txtKonfirmasiPassword.PasswordChar = '*';
            txtKonfirmasiPassword.Size = new Size(300, 23);
            txtKonfirmasiPassword.TabIndex = 8;
            // 
            // lblAlamat
            // 
            lblAlamat.Location = new Point(40, 310);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(100, 23);
            lblAlamat.TabIndex = 9;
            lblAlamat.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(40, 330);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(300, 23);
            txtAlamat.TabIndex = 10;
            // 
            // lblKontak
            // 
            lblKontak.Location = new Point(40, 370);
            lblKontak.Name = "lblKontak";
            lblKontak.Size = new Size(100, 23);
            lblKontak.TabIndex = 11;
            lblKontak.Text = "Kontak";
            // 
            // txtKontak
            // 
            txtKontak.Location = new Point(40, 390);
            txtKontak.Name = "txtKontak";
            txtKontak.Size = new Size(300, 23);
            txtKontak.TabIndex = 12;
            // 
            // lblRole
            // 
            lblRole.Location = new Point(40, 430);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 23);
            lblRole.TabIndex = 13;
            lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "donatur", "penerima", "volunteer" });
            cmbRole.Location = new Point(40, 450);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(300, 23);
            cmbRole.TabIndex = 14;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Green;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(40, 500);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 47);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "DAFTAR";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // lnkLogin
            // 
            lnkLogin.Location = new Point(129, 550);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(100, 23);
            lnkLogin.TabIndex = 16;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Sudah punya akun? Login";
            lnkLogin.LinkClicked += LnkLogin_LinkClicked;
            // 
            // RegisterForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(400, 600);
            Controls.Add(lblTitle);
            Controls.Add(lblNamaLengkap);
            Controls.Add(txtNamaLengkap);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblKonfirmasiPassword);
            Controls.Add(txtKonfirmasiPassword);
            Controls.Add(lblAlamat);
            Controls.Add(txtAlamat);
            Controls.Add(lblKontak);
            Controls.Add(txtKontak);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(btnRegister);
            Controls.Add(lnkLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DonaBook - Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle, lblNamaLengkap, lblUsername, lblPassword, lblKonfirmasiPassword;
        private Label lblAlamat, lblKontak, lblRole;
        private TextBox txtNamaLengkap, txtUsername, txtPassword, txtKonfirmasiPassword;
        private TextBox txtAlamat, txtKontak;
        private ComboBox cmbRole;
        private Button btnRegister;
        private LinkLabel lnkLogin;
    }
}
