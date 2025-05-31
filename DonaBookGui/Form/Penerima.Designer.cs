namespace DonaBookGui.Forms.Penerima
{
    partial class Penerima
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new Label();
            this.btnLogout = new Button();
            this.SuspendLayout();
           
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblWelcome.Location = new Point(30, 30);
            this.lblWelcome.Text = "Selamat datang, ...";
            
            this.btnLogout.Text = "Logout";
            this.btnLogout.Location = new Point(30, 80);
            this.btnLogout.Size = new Size(100, 30);
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            
            this.ClientSize = new Size(400, 200);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Name = "PenerimaForm";
            this.Text = "Dashboard Penerima";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
