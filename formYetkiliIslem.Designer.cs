
namespace BankaDeneme2
{
    partial class formYetkiliIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formYetkiliIslem));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.txtPersonelNumarasi = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnGerıDonn = new System.Windows.Forms.Button();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dataGridPersonelListele = new System.Windows.Forms.DataGridView();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnGeriDonnn = new System.Windows.Forms.Button();
            this.btnBankaIslemListele = new System.Windows.Forms.Button();
            this.dataGridBankaIslem = new System.Windows.Forms.DataGridView();
            this.lblToplamPara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonelListele)).BeginInit();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBankaIslem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(1200, 600);
            this.tabPane1.SelectedPage = this.tabNavigationPage3;
            this.tabPane1.Size = new System.Drawing.Size(1200, 600);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Personel Ekle";
            this.tabNavigationPage1.Controls.Add(this.btnGeriDon);
            this.tabNavigationPage1.Controls.Add(this.btnPersonelEkle);
            this.tabNavigationPage1.Controls.Add(this.txtPersonelSifre);
            this.tabNavigationPage1.Controls.Add(this.txtPersonelNumarasi);
            this.tabNavigationPage1.Controls.Add(this.txtPersonelSoyadi);
            this.tabNavigationPage1.Controls.Add(this.txtPersonelAdi);
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.label3);
            this.tabNavigationPage1.Controls.Add(this.label2);
            this.tabNavigationPage1.Controls.Add(this.label1);
            this.tabNavigationPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage1.ImageOptions.SvgImage")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeriDon.Location = new System.Drawing.Point(624, 369);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(266, 38);
            this.btnGeriDon.TabIndex = 20;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelEkle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPersonelEkle.Location = new System.Drawing.Point(140, 369);
            this.btnPersonelEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(266, 38);
            this.btnPersonelEkle.TabIndex = 20;
            this.btnPersonelEkle.Text = "Oluştur";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(478, 293);
            this.txtPersonelSifre.Multiline = true;
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.PasswordChar = '*';
            this.txtPersonelSifre.Size = new System.Drawing.Size(251, 30);
            this.txtPersonelSifre.TabIndex = 6;
            // 
            // txtPersonelNumarasi
            // 
            this.txtPersonelNumarasi.Location = new System.Drawing.Point(478, 217);
            this.txtPersonelNumarasi.Multiline = true;
            this.txtPersonelNumarasi.Name = "txtPersonelNumarasi";
            this.txtPersonelNumarasi.Size = new System.Drawing.Size(251, 30);
            this.txtPersonelNumarasi.TabIndex = 6;
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(478, 145);
            this.txtPersonelSoyadi.Multiline = true;
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(251, 30);
            this.txtPersonelSoyadi.TabIndex = 6;
            this.txtPersonelSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyadi_KeyPress);
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(478, 75);
            this.txtPersonelAdi.Multiline = true;
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(251, 30);
            this.txtPersonelAdi.TabIndex = 6;
            this.txtPersonelAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelAdi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Adı";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.OrangeRed;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.Caption = "Personel Çıkar";
            this.tabNavigationPage2.Controls.Add(this.btnPersonelSil);
            this.tabNavigationPage2.Controls.Add(this.btnGerıDonn);
            this.tabNavigationPage2.Controls.Add(this.txtPersonelNo);
            this.tabNavigationPage2.Controls.Add(this.label5);
            this.tabNavigationPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage2.ImageOptions.SvgImage")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPersonelSil.Location = new System.Drawing.Point(260, 262);
            this.btnPersonelSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(266, 39);
            this.btnPersonelSil.TabIndex = 23;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnGerıDonn
            // 
            this.btnGerıDonn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerıDonn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGerıDonn.Location = new System.Drawing.Point(630, 262);
            this.btnGerıDonn.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerıDonn.Name = "btnGerıDonn";
            this.btnGerıDonn.Size = new System.Drawing.Size(266, 39);
            this.btnGerıDonn.TabIndex = 22;
            this.btnGerıDonn.Text = "Geri Dön";
            this.btnGerıDonn.UseVisualStyleBackColor = true;
            this.btnGerıDonn.Click += new System.EventHandler(this.btnGerıDonn_Click);
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(488, 142);
            this.txtPersonelNo.Multiline = true;
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(251, 30);
            this.txtPersonelNo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(173, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Personel Numarası";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabNavigationPage3.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage3.Caption = "Personel Listele";
            this.tabNavigationPage3.Controls.Add(this.dataGridPersonelListele);
            this.tabNavigationPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage3.ImageOptions.SvgImage")));
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1200, 547);
            // 
            // dataGridPersonelListele
            // 
            this.dataGridPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonelListele.Location = new System.Drawing.Point(82, 60);
            this.dataGridPersonelListele.Name = "dataGridPersonelListele";
            this.dataGridPersonelListele.RowHeadersWidth = 51;
            this.dataGridPersonelListele.RowTemplate.Height = 24;
            this.dataGridPersonelListele.Size = new System.Drawing.Size(959, 392);
            this.dataGridPersonelListele.TabIndex = 0;
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.tabNavigationPage4.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage4.Caption = "Banka İşlemleri";
            this.tabNavigationPage4.Controls.Add(this.btnGeriDonnn);
            this.tabNavigationPage4.Controls.Add(this.btnBankaIslemListele);
            this.tabNavigationPage4.Controls.Add(this.dataGridBankaIslem);
            this.tabNavigationPage4.Controls.Add(this.lblToplamPara);
            this.tabNavigationPage4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage4.ImageOptions.SvgImage")));
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnGeriDonnn
            // 
            this.btnGeriDonnn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDonnn.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnGeriDonnn.Location = new System.Drawing.Point(625, 487);
            this.btnGeriDonnn.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDonnn.Name = "btnGeriDonnn";
            this.btnGeriDonnn.Size = new System.Drawing.Size(266, 36);
            this.btnGeriDonnn.TabIndex = 23;
            this.btnGeriDonnn.Text = "Geri Dön";
            this.btnGeriDonnn.UseVisualStyleBackColor = true;
            this.btnGeriDonnn.Click += new System.EventHandler(this.btnGeriDonnn_Click);
            // 
            // btnBankaIslemListele
            // 
            this.btnBankaIslemListele.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankaIslemListele.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnBankaIslemListele.Location = new System.Drawing.Point(266, 487);
            this.btnBankaIslemListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnBankaIslemListele.Name = "btnBankaIslemListele";
            this.btnBankaIslemListele.Size = new System.Drawing.Size(266, 36);
            this.btnBankaIslemListele.TabIndex = 21;
            this.btnBankaIslemListele.Text = "Listele";
            this.btnBankaIslemListele.UseVisualStyleBackColor = true;
            this.btnBankaIslemListele.Click += new System.EventHandler(this.btnBankaIslemListele_Click);
            // 
            // dataGridBankaIslem
            // 
            this.dataGridBankaIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBankaIslem.Location = new System.Drawing.Point(66, 64);
            this.dataGridBankaIslem.Name = "dataGridBankaIslem";
            this.dataGridBankaIslem.RowHeadersWidth = 51;
            this.dataGridBankaIslem.RowTemplate.Height = 24;
            this.dataGridBankaIslem.Size = new System.Drawing.Size(959, 396);
            this.dataGridBankaIslem.TabIndex = 3;
            // 
            // lblToplamPara
            // 
            this.lblToplamPara.AutoSize = true;
            this.lblToplamPara.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamPara.Location = new System.Drawing.Point(399, 26);
            this.lblToplamPara.Name = "lblToplamPara";
            this.lblToplamPara.Size = new System.Drawing.Size(237, 21);
            this.lblToplamPara.TabIndex = 2;
            this.lblToplamPara.Text = "Bankanın Toplam Parası : TL";
            // 
            // formYetkiliIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formYetkiliIslem";
            this.Text = "formYetkiliIslem";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonelListele)).EndInit();
            this.tabNavigationPage4.ResumeLayout(false);
            this.tabNavigationPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBankaIslem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelNumarasi;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridPersonelListele;
        private System.Windows.Forms.DataGridView dataGridBankaIslem;
        private System.Windows.Forms.Label lblToplamPara;
        private System.Windows.Forms.Button btnBankaIslemListele;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnGerıDonn;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnGeriDonnn;
    }
}