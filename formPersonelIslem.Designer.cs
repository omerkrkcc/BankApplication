
namespace BankaDeneme2
{
    partial class formPersonelIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPersonelIslem));
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHesapSil = new System.Windows.Forms.Button();
            this.txtHesapNumarasi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGerıDon = new System.Windows.Forms.Button();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnHesapOlustur = new System.Windows.Forms.Button();
            this.txtMusteriEkBakiye = new System.Windows.Forms.TextBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.rBtnTicariMusteri = new System.Windows.Forms.RadioButton();
            this.rBtnBireyselMusteri = new System.Windows.Forms.RadioButton();
            this.dateTimeMusteri = new System.Windows.Forms.DateTimePicker();
            this.btnMusteriOlustur = new System.Windows.Forms.Button();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.txtMusteriNumarasi = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage3.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabNavigationPage3.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage3.Caption = "Hesap Sil";
            this.tabNavigationPage3.Controls.Add(this.label10);
            this.tabNavigationPage3.Controls.Add(this.btnHesapSil);
            this.tabNavigationPage3.Controls.Add(this.txtHesapNumarasi);
            this.tabNavigationPage3.Controls.Add(this.label9);
            this.tabNavigationPage3.Controls.Add(this.btnGerıDon);
            this.tabNavigationPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage3.ImageOptions.SvgImage")));
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1200, 547);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(198, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(839, 30);
            this.label10.TabIndex = 20;
            this.label10.Text = "Herhangi bir hesabın silinebilmesi için bakiye ve ek bakiye 0 olmalıdır.";
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHesapSil.Location = new System.Drawing.Point(330, 220);
            this.btnHesapSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(204, 35);
            this.btnHesapSil.TabIndex = 19;
            this.btnHesapSil.Text = "Hesap Sil";
            this.btnHesapSil.UseVisualStyleBackColor = true;
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // txtHesapNumarasi
            // 
            this.txtHesapNumarasi.Location = new System.Drawing.Point(631, 129);
            this.txtHesapNumarasi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNumarasi.Multiline = true;
            this.txtHesapNumarasi.Name = "txtHesapNumarasi";
            this.txtHesapNumarasi.Size = new System.Drawing.Size(263, 30);
            this.txtHesapNumarasi.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(248, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hesap Numarası ";
            // 
            // btnGerıDon
            // 
            this.btnGerıDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerıDon.Location = new System.Drawing.Point(654, 220);
            this.btnGerıDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerıDon.Name = "btnGerıDon";
            this.btnGerıDon.Size = new System.Drawing.Size(204, 35);
            this.btnGerıDon.TabIndex = 16;
            this.btnGerıDon.Text = "Geri Dön";
            this.btnGerıDon.UseVisualStyleBackColor = true;
            this.btnGerıDon.Click += new System.EventHandler(this.btnGerıDon_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.DarkKhaki;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.Caption = "Hesap Aç";
            this.tabNavigationPage2.Controls.Add(this.btnHesapOlustur);
            this.tabNavigationPage2.Controls.Add(this.txtMusteriEkBakiye);
            this.tabNavigationPage2.Controls.Add(this.txtMusteriNo);
            this.tabNavigationPage2.Controls.Add(this.label8);
            this.tabNavigationPage2.Controls.Add(this.label7);
            this.tabNavigationPage2.Controls.Add(this.btnGeriDon);
            this.tabNavigationPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage2.ImageOptions.SvgImage")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHesapOlustur.Location = new System.Drawing.Point(265, 229);
            this.btnHesapOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(204, 35);
            this.btnHesapOlustur.TabIndex = 19;
            this.btnHesapOlustur.Text = "Hesap Oluştur";
            this.btnHesapOlustur.UseVisualStyleBackColor = true;
            this.btnHesapOlustur.Click += new System.EventHandler(this.btnHesapOlustur_Click);
            // 
            // txtMusteriEkBakiye
            // 
            this.txtMusteriEkBakiye.Location = new System.Drawing.Point(452, 149);
            this.txtMusteriEkBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriEkBakiye.Multiline = true;
            this.txtMusteriEkBakiye.Name = "txtMusteriEkBakiye";
            this.txtMusteriEkBakiye.Size = new System.Drawing.Size(203, 30);
            this.txtMusteriEkBakiye.TabIndex = 18;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(452, 79);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNo.Multiline = true;
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(203, 30);
            this.txtMusteriNo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(140, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Müşterinin Ek Bakiyesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(140, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Müşteri Numarası";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeriDon.Location = new System.Drawing.Point(656, 229);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(204, 35);
            this.btnGeriDon.TabIndex = 14;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Müşteri Ekle";
            this.tabNavigationPage1.Controls.Add(this.btnGeriDön);
            this.tabNavigationPage1.Controls.Add(this.rBtnTicariMusteri);
            this.tabNavigationPage1.Controls.Add(this.rBtnBireyselMusteri);
            this.tabNavigationPage1.Controls.Add(this.dateTimeMusteri);
            this.tabNavigationPage1.Controls.Add(this.btnMusteriOlustur);
            this.tabNavigationPage1.Controls.Add(this.txtMusteriSifre);
            this.tabNavigationPage1.Controls.Add(this.txtMusteriNumarasi);
            this.tabNavigationPage1.Controls.Add(this.txtMusteriSoyadi);
            this.tabNavigationPage1.Controls.Add(this.txtMusteriAdi);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.label5);
            this.tabNavigationPage1.Controls.Add(this.label3);
            this.tabNavigationPage1.Controls.Add(this.label2);
            this.tabNavigationPage1.Controls.Add(this.label1);
            this.tabNavigationPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage1.ImageOptions.SvgImage")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGeriDön.Location = new System.Drawing.Point(629, 441);
            this.btnGeriDön.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(182, 35);
            this.btnGeriDön.TabIndex = 30;
            this.btnGeriDön.Text = "Geri Dön";
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // rBtnTicariMusteri
            // 
            this.rBtnTicariMusteri.AutoSize = true;
            this.rBtnTicariMusteri.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnTicariMusteri.ForeColor = System.Drawing.Color.Red;
            this.rBtnTicariMusteri.Location = new System.Drawing.Point(666, 373);
            this.rBtnTicariMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnTicariMusteri.Name = "rBtnTicariMusteri";
            this.rBtnTicariMusteri.Size = new System.Drawing.Size(145, 26);
            this.rBtnTicariMusteri.TabIndex = 28;
            this.rBtnTicariMusteri.TabStop = true;
            this.rBtnTicariMusteri.Text = "Ticari Müşteri";
            this.rBtnTicariMusteri.UseVisualStyleBackColor = true;
            // 
            // rBtnBireyselMusteri
            // 
            this.rBtnBireyselMusteri.AutoSize = true;
            this.rBtnBireyselMusteri.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnBireyselMusteri.ForeColor = System.Drawing.Color.Red;
            this.rBtnBireyselMusteri.Location = new System.Drawing.Point(448, 372);
            this.rBtnBireyselMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnBireyselMusteri.Name = "rBtnBireyselMusteri";
            this.rBtnBireyselMusteri.Size = new System.Drawing.Size(165, 26);
            this.rBtnBireyselMusteri.TabIndex = 29;
            this.rBtnBireyselMusteri.TabStop = true;
            this.rBtnBireyselMusteri.Text = "Bireysel Müşteri";
            this.rBtnBireyselMusteri.UseVisualStyleBackColor = true;
            // 
            // dateTimeMusteri
            // 
            this.dateTimeMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeMusteri.Location = new System.Drawing.Point(513, 185);
            this.dateTimeMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeMusteri.Name = "dateTimeMusteri";
            this.dateTimeMusteri.Size = new System.Drawing.Size(249, 22);
            this.dateTimeMusteri.TabIndex = 27;
            // 
            // btnMusteriOlustur
            // 
            this.btnMusteriOlustur.ForeColor = System.Drawing.Color.Black;
            this.btnMusteriOlustur.Location = new System.Drawing.Point(305, 441);
            this.btnMusteriOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriOlustur.Name = "btnMusteriOlustur";
            this.btnMusteriOlustur.Size = new System.Drawing.Size(204, 35);
            this.btnMusteriOlustur.TabIndex = 26;
            this.btnMusteriOlustur.Text = "Oluştur";
            this.btnMusteriOlustur.UseVisualStyleBackColor = true;
            this.btnMusteriOlustur.Click += new System.EventHandler(this.btnMusteriOlustur_Click);
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusteriSifre.Location = new System.Drawing.Point(513, 306);
            this.txtMusteriSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriSifre.Multiline = true;
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.PasswordChar = '*';
            this.txtMusteriSifre.Size = new System.Drawing.Size(203, 30);
            this.txtMusteriSifre.TabIndex = 22;
            // 
            // txtMusteriNumarasi
            // 
            this.txtMusteriNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusteriNumarasi.Location = new System.Drawing.Point(513, 241);
            this.txtMusteriNumarasi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNumarasi.Multiline = true;
            this.txtMusteriNumarasi.Name = "txtMusteriNumarasi";
            this.txtMusteriNumarasi.Size = new System.Drawing.Size(203, 30);
            this.txtMusteriNumarasi.TabIndex = 23;
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(513, 120);
            this.txtMusteriSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriSoyadi.Multiline = true;
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(203, 30);
            this.txtMusteriSoyadi.TabIndex = 24;
            this.txtMusteriSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriSoyadi_KeyPress);
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusteriAdi.Location = new System.Drawing.Point(513, 60);
            this.txtMusteriAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriAdi.Multiline = true;
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(203, 30);
            this.txtMusteriAdi.TabIndex = 25;
            this.txtMusteriAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriAdi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(242, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Müşteri Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(242, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(242, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(242, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Müşteri Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(242, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(242, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adı";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1200, 600);
            this.tabPane1.SelectedPage = this.tabNavigationPage3;
            this.tabPane1.Size = new System.Drawing.Size(1200, 600);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // formPersonelIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPersonelIslem";
            this.Text = "formPersonelIslem";
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHesapSil;
        private System.Windows.Forms.TextBox txtHesapNumarasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGerıDon;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.Button btnHesapOlustur;
        private System.Windows.Forms.TextBox txtMusteriEkBakiye;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGeriDon;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.Button btnGeriDön;
        private System.Windows.Forms.RadioButton rBtnTicariMusteri;
        private System.Windows.Forms.RadioButton rBtnBireyselMusteri;
        private System.Windows.Forms.DateTimePicker dateTimeMusteri;
        private System.Windows.Forms.Button btnMusteriOlustur;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.TextBox txtMusteriNumarasi;
        private System.Windows.Forms.TextBox txtMusteriSoyadi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
    }
}