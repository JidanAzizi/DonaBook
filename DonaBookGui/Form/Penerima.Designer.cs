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
            lblWelcome = new Label();
            btnLogout = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            button1 = new Button();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Judul = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(226, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat datang, ...";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(734, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(822, 576);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(814, 543);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cari Buku";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(25, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 443);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hasil Pencarian:";
            // 
            // button3
            // 
            button3.Location = new Point(489, 34);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Cari";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Judul atau Genre:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(814, 543);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ambil Buku";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(413, 30);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Ambil";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 27);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 33);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Id Buku:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(814, 543);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rating & Review";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 266);
            button1.Name = "button1";
            button1.Size = new Size(426, 34);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(36, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 83);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beri Rating:";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(305, 36);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(38, 24);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(239, 36);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(38, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(178, 36);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(38, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(120, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(38, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(59, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 158);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(145, 84);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 34);
            textBox4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 84);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 2;
            label4.Text = "Beri Ulasan:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 27);
            textBox3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 37);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 0;
            label3.Text = "Id Buku:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Judul, Author, Genre, Quantity });
            dataGridView1.Location = new Point(27, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 387);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Judul
            // 
            Judul.HeaderText = "Judul";
            Judul.MinimumWidth = 6;
            Judul.Name = "Judul";
            Judul.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Penerima
            // 
            ClientSize = new Size(846, 694);
            Controls.Add(tabControl1);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Name = "Penerima";
            Text = "Dashboard Penerima";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Label label1;
        private TabPage tabPage3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Quantity;
    }
}
