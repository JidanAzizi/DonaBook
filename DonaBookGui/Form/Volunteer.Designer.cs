namespace DonaBookGui.Forms.Volunteer
{
    partial class VolunteerForm
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
            // 
            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblWelcome.Location = new Point(30, 30);
            this.lblWelcome.Text = "Selamat datang, ...";
            // 
            // btnLogout
            this.btnLogout.Text = "Logout";
            this.btnLogout.Location = new Point(30, 80);
            this.btnLogout.Size = new Size(100, 30);
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            // 
            // VolunteerForm
            this.ClientSize = new Size(400, 200);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Name = "VolunteerForm";
            this.Text = "Dashboard Volunteer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
