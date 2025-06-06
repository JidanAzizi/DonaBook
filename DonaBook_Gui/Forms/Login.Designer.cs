namespace DonaBook_Gui.Forms
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();

            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(30, 30);
            lblUsername.Text = "Username";

            txtUsername.Location = new System.Drawing.Point(130, 27);
            txtUsername.Size = new System.Drawing.Size(180, 31);

            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(30, 80);
            lblPassword.Text = "Password";

            txtPassword.Location = new System.Drawing.Point(130, 77);
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(180, 31);

            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(130, 130);
            btnLogin.Size = new System.Drawing.Size(90, 30);
            btnLogin.Click += btnLogin_Click;

            ClientSize = new System.Drawing.Size(360, 200);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Text = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
