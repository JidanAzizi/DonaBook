namespace DonaBookGui.Forms.Donatur
{
    partial class Donatur
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnLogout;
        private Button btnSelesaiPengajuan;

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
            labelPengajuanDonasi = new Label();
            genreLabel = new Label();
            categoryLabel = new Label();
            conditionLabel = new Label();
            stateLabel = new Label();
            fictionLabelGenre = new CheckBox();
            nonFictionLabelGenre = new CheckBox();
            scienceFictionLabelGenre = new CheckBox();
            fantasyLabelGenre = new CheckBox();
            mysteryLabelGenre = new CheckBox();
            romanceLabelGenre = new CheckBox();
            horrorLabelGenre = new CheckBox();
            biographyLabelGenre = new CheckBox();
            selfHelpLabelGenre = new CheckBox();
            historyLabelGenre = new CheckBox();
            unknownLabelGenre = new CheckBox();
            judulLabelFitur1 = new Label();
            textboxJudulFitur1 = new TextBox();
            textboxPenulisFitur1 = new TextBox();
            penulisLabelFitur1 = new Label();
            labelHapusBukuDonasi = new Label();
            judulLabelFitur2 = new Label();
            textBoxJudulFitur2 = new TextBox();
            labelPenulisFitur2 = new Label();
            textBoxPenulisFitur2 = new TextBox();
            baruButtonCondition = new CheckBox();
            bekasRusakButtonCondition = new CheckBox();
            bekasBaikButtonCondition = new CheckBox();
            anakAnakButtonCat = new CheckBox();
            remajaButtonCat = new CheckBox();
            dewasaButtonCat = new CheckBox();
            draftButtonState = new CheckBox();
            submittedButtonState = new CheckBox();
            verifiedButtonState = new CheckBox();
            rejectedButtonState = new CheckBox();
            btnHapusBuku = new Button();
            btnSelesaiDonasi = new Button();
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
            btnLogout.Location = new Point(30, 590);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // labelPengajuanDonasi
            // 
            labelPengajuanDonasi.AutoSize = true;
            labelPengajuanDonasi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPengajuanDonasi.Location = new Point(26, 77);
            labelPengajuanDonasi.Name = "labelPengajuanDonasi";
            labelPengajuanDonasi.Size = new Size(181, 28);
            labelPengajuanDonasi.TabIndex = 2;
            labelPengajuanDonasi.Text = "Pengajuan Donasi";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genreLabel.Location = new Point(32, 165);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(56, 23);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "Genre";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.Location = new Point(629, 165);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(81, 23);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            conditionLabel.Location = new Point(32, 300);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(85, 23);
            conditionLabel.TabIndex = 5;
            conditionLabel.Text = "Condition";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stateLabel.Location = new Point(629, 300);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(76, 23);
            stateLabel.TabIndex = 7;
            stateLabel.Text = "Keadaan";
            // 
            // fictionLabelGenre
            // 
            fictionLabelGenre.AutoSize = true;
            fictionLabelGenre.Location = new Point(160, 166);
            fictionLabelGenre.Name = "fictionLabelGenre";
            fictionLabelGenre.Size = new Size(75, 24);
            fictionLabelGenre.TabIndex = 8;
            fictionLabelGenre.Text = "Fiction";
            fictionLabelGenre.UseVisualStyleBackColor = true;
            // 
            // nonFictionLabelGenre
            // 
            nonFictionLabelGenre.AutoSize = true;
            nonFictionLabelGenre.Location = new Point(160, 196);
            nonFictionLabelGenre.Name = "nonFictionLabelGenre";
            nonFictionLabelGenre.Size = new Size(103, 24);
            nonFictionLabelGenre.TabIndex = 9;
            nonFictionLabelGenre.Text = "NonFiction";
            nonFictionLabelGenre.UseVisualStyleBackColor = true;
            // 
            // scienceFictionLabelGenre
            // 
            scienceFictionLabelGenre.AutoSize = true;
            scienceFictionLabelGenre.Location = new Point(160, 226);
            scienceFictionLabelGenre.Name = "scienceFictionLabelGenre";
            scienceFictionLabelGenre.Size = new Size(125, 24);
            scienceFictionLabelGenre.TabIndex = 10;
            scienceFictionLabelGenre.Text = "ScienceFiction";
            scienceFictionLabelGenre.UseVisualStyleBackColor = true;
            // 
            // fantasyLabelGenre
            // 
            fantasyLabelGenre.AutoSize = true;
            fantasyLabelGenre.Location = new Point(160, 256);
            fantasyLabelGenre.Name = "fantasyLabelGenre";
            fantasyLabelGenre.Size = new Size(79, 24);
            fantasyLabelGenre.TabIndex = 11;
            fantasyLabelGenre.Text = "Fantasy";
            fantasyLabelGenre.UseVisualStyleBackColor = true;
            // 
            // mysteryLabelGenre
            // 
            mysteryLabelGenre.AutoSize = true;
            mysteryLabelGenre.Location = new Point(328, 166);
            mysteryLabelGenre.Name = "mysteryLabelGenre";
            mysteryLabelGenre.Size = new Size(82, 24);
            mysteryLabelGenre.TabIndex = 12;
            mysteryLabelGenre.Text = "Mystery";
            mysteryLabelGenre.UseVisualStyleBackColor = true;
            // 
            // romanceLabelGenre
            // 
            romanceLabelGenre.AutoSize = true;
            romanceLabelGenre.Location = new Point(328, 196);
            romanceLabelGenre.Name = "romanceLabelGenre";
            romanceLabelGenre.Size = new Size(93, 24);
            romanceLabelGenre.TabIndex = 13;
            romanceLabelGenre.Text = "Romance";
            romanceLabelGenre.UseVisualStyleBackColor = true;
            // 
            // horrorLabelGenre
            // 
            horrorLabelGenre.AutoSize = true;
            horrorLabelGenre.Location = new Point(328, 226);
            horrorLabelGenre.Name = "horrorLabelGenre";
            horrorLabelGenre.Size = new Size(75, 24);
            horrorLabelGenre.TabIndex = 14;
            horrorLabelGenre.Text = "Horror";
            horrorLabelGenre.UseVisualStyleBackColor = true;
            // 
            // biographyLabelGenre
            // 
            biographyLabelGenre.AutoSize = true;
            biographyLabelGenre.Location = new Point(328, 256);
            biographyLabelGenre.Name = "biographyLabelGenre";
            biographyLabelGenre.RightToLeft = RightToLeft.No;
            biographyLabelGenre.Size = new Size(99, 24);
            biographyLabelGenre.TabIndex = 15;
            biographyLabelGenre.Text = "Biography";
            biographyLabelGenre.UseVisualStyleBackColor = true;
            // 
            // selfHelpLabelGenre
            // 
            selfHelpLabelGenre.AutoSize = true;
            selfHelpLabelGenre.Location = new Point(470, 166);
            selfHelpLabelGenre.Name = "selfHelpLabelGenre";
            selfHelpLabelGenre.Size = new Size(88, 24);
            selfHelpLabelGenre.TabIndex = 16;
            selfHelpLabelGenre.Text = "SelfHelp";
            selfHelpLabelGenre.UseVisualStyleBackColor = true;
            // 
            // historyLabelGenre
            // 
            historyLabelGenre.AutoSize = true;
            historyLabelGenre.Location = new Point(470, 196);
            historyLabelGenre.Name = "historyLabelGenre";
            historyLabelGenre.Size = new Size(78, 24);
            historyLabelGenre.TabIndex = 17;
            historyLabelGenre.Text = "History";
            historyLabelGenre.UseVisualStyleBackColor = true;
            // 
            // unknownLabelGenre
            // 
            unknownLabelGenre.AutoSize = true;
            unknownLabelGenre.Location = new Point(470, 226);
            unknownLabelGenre.Name = "unknownLabelGenre";
            unknownLabelGenre.Size = new Size(92, 24);
            unknownLabelGenre.TabIndex = 18;
            unknownLabelGenre.Text = "Unknown";
            unknownLabelGenre.UseVisualStyleBackColor = true;
            // 
            // judulLabelFitur1
            // 
            judulLabelFitur1.AutoSize = true;
            judulLabelFitur1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            judulLabelFitur1.Location = new Point(32, 125);
            judulLabelFitur1.Name = "judulLabelFitur1";
            judulLabelFitur1.Size = new Size(51, 23);
            judulLabelFitur1.TabIndex = 29;
            judulLabelFitur1.Text = "Judul";
            // 
            // textboxJudulFitur1
            // 
            textboxJudulFitur1.Location = new Point(160, 121);
            textboxJudulFitur1.Name = "textboxJudulFitur1";
            textboxJudulFitur1.Size = new Size(308, 27);
            textboxJudulFitur1.TabIndex = 30;
            textboxJudulFitur1.TextChanged += textboxJudulFitur1Text;
            // 
            // textboxPenulisFitur1
            // 
            textboxPenulisFitur1.Location = new Point(748, 121);
            textboxPenulisFitur1.Name = "textboxPenulisFitur1";
            textboxPenulisFitur1.Size = new Size(230, 27);
            textboxPenulisFitur1.TabIndex = 31;
            // 
            // penulisLabelFitur1
            // 
            penulisLabelFitur1.AutoSize = true;
            penulisLabelFitur1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            penulisLabelFitur1.Location = new Point(629, 125);
            penulisLabelFitur1.Name = "penulisLabelFitur1";
            penulisLabelFitur1.Size = new Size(63, 23);
            penulisLabelFitur1.TabIndex = 32;
            penulisLabelFitur1.Text = "Penulis";
            // 
            // labelHapusBukuDonasi
            // 
            labelHapusBukuDonasi.AutoSize = true;
            labelHapusBukuDonasi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHapusBukuDonasi.Location = new Point(26, 420);
            labelHapusBukuDonasi.Name = "labelHapusBukuDonasi";
            labelHapusBukuDonasi.Size = new Size(196, 28);
            labelHapusBukuDonasi.TabIndex = 33;
            labelHapusBukuDonasi.Text = "Hapus Buku Donasi";
            // 
            // judulLabelFitur2
            // 
            judulLabelFitur2.AutoSize = true;
            judulLabelFitur2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            judulLabelFitur2.Location = new Point(30, 467);
            judulLabelFitur2.Name = "judulLabelFitur2";
            judulLabelFitur2.Size = new Size(51, 23);
            judulLabelFitur2.TabIndex = 34;
            judulLabelFitur2.Text = "Judul";
            // 
            // textBoxJudulFitur2
            // 
            textBoxJudulFitur2.Location = new Point(160, 466);
            textBoxJudulFitur2.Name = "textBoxJudulFitur2";
            textBoxJudulFitur2.Size = new Size(308, 27);
            textBoxJudulFitur2.TabIndex = 35;
            // 
            // labelPenulisFitur2
            // 
            labelPenulisFitur2.AutoSize = true;
            labelPenulisFitur2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPenulisFitur2.Location = new Point(30, 499);
            labelPenulisFitur2.Name = "labelPenulisFitur2";
            labelPenulisFitur2.Size = new Size(63, 23);
            labelPenulisFitur2.TabIndex = 36;
            labelPenulisFitur2.Text = "Penulis";
            // 
            // textBoxPenulisFitur2
            // 
            textBoxPenulisFitur2.Location = new Point(160, 499);
            textBoxPenulisFitur2.Name = "textBoxPenulisFitur2";
            textBoxPenulisFitur2.Size = new Size(308, 27);
            textBoxPenulisFitur2.TabIndex = 37;
            // 
            // baruButtonCondition
            // 
            baruButtonCondition.AutoSize = true;
            baruButtonCondition.Location = new Point(160, 300);
            baruButtonCondition.Name = "baruButtonCondition";
            baruButtonCondition.Size = new Size(61, 24);
            baruButtonCondition.TabIndex = 38;
            baruButtonCondition.Text = "Baru";
            baruButtonCondition.UseVisualStyleBackColor = true;
            baruButtonCondition.CheckedChanged += conditionButtonGroupBaru;
            // 
            // bekasRusakButtonCondition
            // 
            bekasRusakButtonCondition.AutoSize = true;
            bekasRusakButtonCondition.Location = new Point(160, 330);
            bekasRusakButtonCondition.Name = "bekasRusakButtonCondition";
            bekasRusakButtonCondition.Size = new Size(140, 24);
            bekasRusakButtonCondition.TabIndex = 39;
            bekasRusakButtonCondition.Text = "Bekas dan Rusak";
            bekasRusakButtonCondition.UseVisualStyleBackColor = true;
            bekasRusakButtonCondition.CheckedChanged += conditionButtonGroupBekasRusak;
            // 
            // bekasBaikButtonCondition
            // 
            bekasBaikButtonCondition.AutoSize = true;
            bekasBaikButtonCondition.Location = new Point(328, 300);
            bekasBaikButtonCondition.Name = "bekasBaikButtonCondition";
            bekasBaikButtonCondition.Size = new Size(130, 24);
            bekasBaikButtonCondition.TabIndex = 40;
            bekasBaikButtonCondition.Text = "Bekas dan Baik";
            bekasBaikButtonCondition.UseVisualStyleBackColor = true;
            bekasBaikButtonCondition.CheckedChanged += conditionButtonGroupBekasBaik;
            // 
            // anakAnakButtonCat
            // 
            anakAnakButtonCat.AutoSize = true;
            anakAnakButtonCat.Location = new Point(748, 166);
            anakAnakButtonCat.Name = "anakAnakButtonCat";
            anakAnakButtonCat.Size = new Size(64, 24);
            anakAnakButtonCat.TabIndex = 41;
            anakAnakButtonCat.Text = "Anak";
            anakAnakButtonCat.UseVisualStyleBackColor = true;
            anakAnakButtonCat.CheckedChanged += categoryButtonGroupAnak;
            // 
            // remajaButtonCat
            // 
            remajaButtonCat.AutoSize = true;
            remajaButtonCat.Location = new Point(748, 196);
            remajaButtonCat.Name = "remajaButtonCat";
            remajaButtonCat.Size = new Size(81, 24);
            remajaButtonCat.TabIndex = 42;
            remajaButtonCat.Text = "Remaja";
            remajaButtonCat.UseVisualStyleBackColor = true;
            remajaButtonCat.CheckedChanged += categoryButtonGroupRemaja;
            // 
            // dewasaButtonCat
            // 
            dewasaButtonCat.AutoSize = true;
            dewasaButtonCat.Location = new Point(748, 226);
            dewasaButtonCat.Name = "dewasaButtonCat";
            dewasaButtonCat.Size = new Size(83, 24);
            dewasaButtonCat.TabIndex = 43;
            dewasaButtonCat.Text = "Dewasa";
            dewasaButtonCat.UseVisualStyleBackColor = true;
            dewasaButtonCat.CheckedChanged += categoryButtonGroupDewasa;
            // 
            // draftButtonState
            // 
            draftButtonState.AutoSize = true;
            draftButtonState.Location = new Point(748, 299);
            draftButtonState.Name = "draftButtonState";
            draftButtonState.Size = new Size(65, 24);
            draftButtonState.TabIndex = 44;
            draftButtonState.Text = "Draft";
            draftButtonState.UseVisualStyleBackColor = true;
            draftButtonState.CheckedChanged += stateButtonGroupDraft;
            // 
            // submittedButtonState
            // 
            submittedButtonState.AutoSize = true;
            submittedButtonState.Location = new Point(748, 329);
            submittedButtonState.Name = "submittedButtonState";
            submittedButtonState.Size = new Size(100, 24);
            submittedButtonState.TabIndex = 45;
            submittedButtonState.Text = "Submitted";
            submittedButtonState.UseVisualStyleBackColor = true;
            submittedButtonState.CheckedChanged += stateButtonGroupSubmitted;
            // 
            // verifiedButtonState
            // 
            verifiedButtonState.AutoSize = true;
            verifiedButtonState.Location = new Point(888, 299);
            verifiedButtonState.Name = "verifiedButtonState";
            verifiedButtonState.Size = new Size(82, 24);
            verifiedButtonState.TabIndex = 46;
            verifiedButtonState.Text = "Verified";
            verifiedButtonState.UseVisualStyleBackColor = true;
            verifiedButtonState.CheckedChanged += stateButtonGroupVerified;
            // 
            // rejectedButtonState
            // 
            rejectedButtonState.AutoSize = true;
            rejectedButtonState.Location = new Point(888, 330);
            rejectedButtonState.Name = "rejectedButtonState";
            rejectedButtonState.Size = new Size(89, 24);
            rejectedButtonState.TabIndex = 47;
            rejectedButtonState.Text = "Rejected";
            rejectedButtonState.UseVisualStyleBackColor = true;
            rejectedButtonState.CheckedChanged += stateButtonGroupRejected;
            // 
            // btnHapusBuku
            // 
            btnHapusBuku.Location = new Point(374, 533);
            btnHapusBuku.Name = "btnHapusBuku";
            btnHapusBuku.Size = new Size(94, 29);
            btnHapusBuku.TabIndex = 49;
            btnHapusBuku.Text = "Hapus";
            btnHapusBuku.UseVisualStyleBackColor = true;
            // 
            // btnSelesaiDonasi
            // 
            btnSelesaiDonasi.Location = new Point(501, 352);
            btnSelesaiDonasi.Name = "btnSelesaiDonasi";
            btnSelesaiDonasi.Size = new Size(94, 29);
            btnSelesaiDonasi.TabIndex = 50;
            btnSelesaiDonasi.Text = "Selesai";
            btnSelesaiDonasi.UseVisualStyleBackColor = true;
            btnSelesaiDonasi.Click += btnSelesaiDonasiBuku;
            // 
            // Donatur
            // 
            ClientSize = new Size(1061, 638);
            Controls.Add(btnSelesaiDonasi);
            Controls.Add(btnHapusBuku);
            Controls.Add(rejectedButtonState);
            Controls.Add(verifiedButtonState);
            Controls.Add(submittedButtonState);
            Controls.Add(draftButtonState);
            Controls.Add(dewasaButtonCat);
            Controls.Add(remajaButtonCat);
            Controls.Add(anakAnakButtonCat);
            Controls.Add(bekasBaikButtonCondition);
            Controls.Add(bekasRusakButtonCondition);
            Controls.Add(baruButtonCondition);
            Controls.Add(textBoxPenulisFitur2);
            Controls.Add(labelPenulisFitur2);
            Controls.Add(textBoxJudulFitur2);
            Controls.Add(judulLabelFitur2);
            Controls.Add(labelHapusBukuDonasi);
            Controls.Add(penulisLabelFitur1);
            Controls.Add(textboxPenulisFitur1);
            Controls.Add(textboxJudulFitur1);
            Controls.Add(judulLabelFitur1);
            Controls.Add(unknownLabelGenre);
            Controls.Add(historyLabelGenre);
            Controls.Add(selfHelpLabelGenre);
            Controls.Add(biographyLabelGenre);
            Controls.Add(horrorLabelGenre);
            Controls.Add(romanceLabelGenre);
            Controls.Add(mysteryLabelGenre);
            Controls.Add(fantasyLabelGenre);
            Controls.Add(scienceFictionLabelGenre);
            Controls.Add(nonFictionLabelGenre);
            Controls.Add(fictionLabelGenre);
            Controls.Add(stateLabel);
            Controls.Add(conditionLabel);
            Controls.Add(categoryLabel);
            Controls.Add(genreLabel);
            Controls.Add(labelPengajuanDonasi);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Name = "Donatur";
            Text = "Dashboard Donatur";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelPengajuanDonasi;
        private Label genreLabel;
        private Label categoryLabel;
        private Label conditionLabel;
        private Label stateLabel;
        private CheckBox fictionLabelGenre;
        private CheckBox nonFictionLabelGenre;
        private CheckBox scienceFictionLabelGenre;
        private CheckBox fantasyLabelGenre;
        private CheckBox mysteryLabelGenre;
        private CheckBox romanceLabelGenre;
        private CheckBox horrorLabelGenre;
        private CheckBox biographyLabelGenre;
        private CheckBox selfHelpLabelGenre;
        private CheckBox historyLabelGenre;
        private CheckBox unknownLabelGenre;
        private Label judulLabelFitur1;
        private TextBox textboxJudulFitur1;
        private TextBox textboxPenulisFitur1;
        private Label penulisLabelFitur1;
        private Label labelHapusBukuDonasi;
        private Label judulLabelFitur2;
        private TextBox textBoxJudulFitur2;
        private Label labelPenulisFitur2;
        private TextBox textBoxPenulisFitur2;
        private CheckBox baruButtonCondition;
        private CheckBox bekasRusakButtonCondition;
        private CheckBox bekasBaikButtonCondition;
        private CheckBox anakAnakButtonCat;
        private CheckBox remajaButtonCat;
        private CheckBox dewasaButtonCat;
        private CheckBox draftButtonState;
        private CheckBox submittedButtonState;
        private CheckBox verifiedButtonState;
        private CheckBox rejectedButtonState;
        private Button btnHapusBuku;
        private Button btnSelesaiDonasi;
    }
}
