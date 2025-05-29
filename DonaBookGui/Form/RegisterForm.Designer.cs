using System.Windows.Forms;

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
            btnRegister = new Button();
            lnkLogin = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.Location = new Point(88, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BUAT AKUN BARU";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblNamaLengkap
            // 
            lblNamaLengkap.AutoSize = true;
            lblNamaLengkap.Font = new Font("Segoe UI", 9.75F);
            lblNamaLengkap.Location = new Point(47, 81);
            lblNamaLengkap.Margin = new Padding(4, 0, 4, 0);
            lblNamaLengkap.Name = "lblNamaLengkap";
            lblNamaLengkap.Size = new Size(96, 17);
            lblNamaLengkap.TabIndex = 1;
            lblNamaLengkap.Text = "Nama Lengkap";
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Font = new Font("Segoe UI", 9.75F);
            txtNamaLengkap.Location = new Point(50, 104);
            txtNamaLengkap.Margin = new Padding(4, 3, 4, 3);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(291, 25);
            txtNamaLengkap.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F);
            lblUsername.Location = new Point(47, 150);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(103, 17);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username/Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9.75F);
            txtUsername.Location = new Point(50, 173);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 25);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F);
            lblPassword.Location = new Point(47, 219);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(64, 17);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F);
            txtPassword.Location = new Point(50, 242);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(291, 25);
            txtPassword.TabIndex = 6;
            // 
            // lblKonfirmasiPassword
            // 
            lblKonfirmasiPassword.AutoSize = true;
            lblKonfirmasiPassword.Font = new Font("Segoe UI", 9.75F);
            lblKonfirmasiPassword.Location = new Point(47, 288);
            lblKonfirmasiPassword.Margin = new Padding(4, 0, 4, 0);
            lblKonfirmasiPassword.Name = "lblKonfirmasiPassword";
            lblKonfirmasiPassword.Size = new Size(130, 17);
            lblKonfirmasiPassword.TabIndex = 7;
            lblKonfirmasiPassword.Text = "Konfirmasi Password";
            // 
            // txtKonfirmasiPassword
            // 
            txtKonfirmasiPassword.Font = new Font("Segoe UI", 9.75F);
            txtKonfirmasiPassword.Location = new Point(50, 312);
            txtKonfirmasiPassword.Margin = new Padding(4, 3, 4, 3);
            txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
            txtKonfirmasiPassword.PasswordChar = '*';
            txtKonfirmasiPassword.Size = new Size(291, 25);
            txtKonfirmasiPassword.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(50, 369);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(292, 46);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "DAFTAR";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Font = new Font("Segoe UI", 9F);
            lnkLogin.Location = new Point(99, 433);
            lnkLogin.Margin = new Padding(4, 0, 4, 0);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(177, 15);
            lnkLogin.TabIndex = 10;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Sudah punya akun? Login di sini";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(390, 486);
            Controls.Add(lnkLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtKonfirmasiPassword);
            Controls.Add(lblKonfirmasiPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtNamaLengkap);
            Controls.Add(lblNamaLengkap);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DonaBook - Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNamaLengkap;
        private TextBox txtNamaLengkap;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblKonfirmasiPassword;
        private TextBox txtKonfirmasiPassword;
        private Button btnRegister;
        private LinkLabel lnkLogin;
    }
}
