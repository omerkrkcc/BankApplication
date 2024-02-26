
namespace BankaDeneme2
{
    partial class formMusteriIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMusteriIslem));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.txtCekilmekIstenenPara = new System.Windows.Forms.TextBox();
            this.txtHesapNumarasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnGerıDon = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.txtYatirilanPara = new System.Windows.Forms.TextBox();
            this.txtParaHesapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnHavaleGönder = new System.Windows.Forms.Button();
            this.txtHavaleMiktar = new System.Windows.Forms.TextBox();
            this.txtHavaleHesapNo = new System.Windows.Forms.TextBox();
            this.txtAnaHesapNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnGeriDonList = new System.Windows.Forms.Button();
            this.btnHesapListele = new System.Windows.Forms.Button();
            this.dataGridHesaplar = new System.Windows.Forms.DataGridView();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnOzetGeriDon = new System.Windows.Forms.Button();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnOzetiListele = new System.Windows.Forms.Button();
            this.txtHesapOzetNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridOzet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesaplar)).BeginInit();
            this.tabNavigationPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOzet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4,
            this.tabNavigationPage5});
            this.tabPane1.RegularSize = new System.Drawing.Size(1200, 600);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1200, 600);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Para Çek";
            this.tabNavigationPage1.Controls.Add(this.btnGeriDön);
            this.tabNavigationPage1.Controls.Add(this.btnParaCek);
            this.tabNavigationPage1.Controls.Add(this.txtCekilmekIstenenPara);
            this.tabNavigationPage1.Controls.Add(this.txtHesapNumarasi);
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.label1);
            this.tabNavigationPage1.Controls.Add(this.label3);
            this.tabNavigationPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage1.ImageOptions.SvgImage")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.BackColor = System.Drawing.Color.Honeydew;
            this.btnGeriDön.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDön.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGeriDön.Location = new System.Drawing.Point(715, 300);
            this.btnGeriDön.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(204, 35);
            this.btnGeriDön.TabIndex = 15;
            this.btnGeriDön.Text = "Geri Dön";
            this.btnGeriDön.UseVisualStyleBackColor = false;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.Color.Honeydew;
            this.btnParaCek.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaCek.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnParaCek.Location = new System.Drawing.Point(283, 300);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(204, 35);
            this.btnParaCek.TabIndex = 14;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // txtCekilmekIstenenPara
            // 
            this.txtCekilmekIstenenPara.Location = new System.Drawing.Point(622, 225);
            this.txtCekilmekIstenenPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtCekilmekIstenenPara.Multiline = true;
            this.txtCekilmekIstenenPara.Name = "txtCekilmekIstenenPara";
            this.txtCekilmekIstenenPara.Size = new System.Drawing.Size(203, 36);
            this.txtCekilmekIstenenPara.TabIndex = 12;
            // 
            // txtHesapNumarasi
            // 
            this.txtHesapNumarasi.Location = new System.Drawing.Point(622, 160);
            this.txtHesapNumarasi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNumarasi.Multiline = true;
            this.txtHesapNumarasi.Name = "txtHesapNumarasi";
            this.txtHesapNumarasi.Size = new System.Drawing.Size(203, 30);
            this.txtHesapNumarasi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(426, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Miktar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.Location = new System.Drawing.Point(383, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Günlük para çekme limitiniz 750 TL\'dir.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(347, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hesap Numarası";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.Caption = "Para Yatırma";
            this.tabNavigationPage2.Controls.Add(this.btnGerıDon);
            this.tabNavigationPage2.Controls.Add(this.btnParaYatir);
            this.tabNavigationPage2.Controls.Add(this.txtYatirilanPara);
            this.tabNavigationPage2.Controls.Add(this.txtParaHesapNo);
            this.tabNavigationPage2.Controls.Add(this.label2);
            this.tabNavigationPage2.Controls.Add(this.label6);
            this.tabNavigationPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage2.ImageOptions.SvgImage")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnGerıDon
            // 
            this.btnGerıDon.BackColor = System.Drawing.Color.LightBlue;
            this.btnGerıDon.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnGerıDon.ForeColor = System.Drawing.Color.Olive;
            this.btnGerıDon.Location = new System.Drawing.Point(723, 268);
            this.btnGerıDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerıDon.Name = "btnGerıDon";
            this.btnGerıDon.Size = new System.Drawing.Size(204, 42);
            this.btnGerıDon.TabIndex = 20;
            this.btnGerıDon.Text = "Geri Dön";
            this.btnGerıDon.UseVisualStyleBackColor = false;
            this.btnGerıDon.Click += new System.EventHandler(this.btnGerıDon_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.BackColor = System.Drawing.Color.LightBlue;
            this.btnParaYatir.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnParaYatir.ForeColor = System.Drawing.Color.Olive;
            this.btnParaYatir.Location = new System.Drawing.Point(353, 268);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(204, 42);
            this.btnParaYatir.TabIndex = 19;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = false;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // txtYatirilanPara
            // 
            this.txtYatirilanPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYatirilanPara.Location = new System.Drawing.Point(598, 190);
            this.txtYatirilanPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtYatirilanPara.Multiline = true;
            this.txtYatirilanPara.Name = "txtYatirilanPara";
            this.txtYatirilanPara.Size = new System.Drawing.Size(203, 30);
            this.txtYatirilanPara.TabIndex = 17;
            // 
            // txtParaHesapNo
            // 
            this.txtParaHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParaHesapNo.Location = new System.Drawing.Point(598, 125);
            this.txtParaHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtParaHesapNo.Multiline = true;
            this.txtParaHesapNo.Name = "txtParaHesapNo";
            this.txtParaHesapNo.Size = new System.Drawing.Size(203, 30);
            this.txtParaHesapNo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(407, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.Bisque;
            this.label6.Location = new System.Drawing.Point(351, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hesap Numarası";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.tabNavigationPage3.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage3.Caption = "Hesaplar Arası Havale";
            this.tabNavigationPage3.Controls.Add(this.btnGeriDon);
            this.tabNavigationPage3.Controls.Add(this.btnHavaleGönder);
            this.tabNavigationPage3.Controls.Add(this.txtHavaleMiktar);
            this.tabNavigationPage3.Controls.Add(this.txtHavaleHesapNo);
            this.tabNavigationPage3.Controls.Add(this.txtAnaHesapNo);
            this.tabNavigationPage3.Controls.Add(this.label5);
            this.tabNavigationPage3.Controls.Add(this.label7);
            this.tabNavigationPage3.Controls.Add(this.label8);
            this.tabNavigationPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage3.ImageOptions.SvgImage")));
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGeriDon.Location = new System.Drawing.Point(622, 287);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(248, 42);
            this.btnGeriDon.TabIndex = 22;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnHavaleGönder
            // 
            this.btnHavaleGönder.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnHavaleGönder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHavaleGönder.Location = new System.Drawing.Point(263, 287);
            this.btnHavaleGönder.Margin = new System.Windows.Forms.Padding(4);
            this.btnHavaleGönder.Name = "btnHavaleGönder";
            this.btnHavaleGönder.Size = new System.Drawing.Size(261, 44);
            this.btnHavaleGönder.TabIndex = 21;
            this.btnHavaleGönder.Text = "Gönder";
            this.btnHavaleGönder.UseVisualStyleBackColor = true;
            this.btnHavaleGönder.Click += new System.EventHandler(this.btnHavaleGönder_Click);
            // 
            // txtHavaleMiktar
            // 
            this.txtHavaleMiktar.Location = new System.Drawing.Point(667, 216);
            this.txtHavaleMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtHavaleMiktar.Multiline = true;
            this.txtHavaleMiktar.Name = "txtHavaleMiktar";
            this.txtHavaleMiktar.Size = new System.Drawing.Size(203, 30);
            this.txtHavaleMiktar.TabIndex = 18;
            // 
            // txtHavaleHesapNo
            // 
            this.txtHavaleHesapNo.Location = new System.Drawing.Point(667, 151);
            this.txtHavaleHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHavaleHesapNo.Multiline = true;
            this.txtHavaleHesapNo.Name = "txtHavaleHesapNo";
            this.txtHavaleHesapNo.Size = new System.Drawing.Size(203, 31);
            this.txtHavaleHesapNo.TabIndex = 19;
            // 
            // txtAnaHesapNo
            // 
            this.txtAnaHesapNo.Location = new System.Drawing.Point(667, 89);
            this.txtAnaHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnaHesapNo.Multiline = true;
            this.txtAnaHesapNo.Name = "txtAnaHesapNo";
            this.txtAnaHesapNo.Size = new System.Drawing.Size(203, 30);
            this.txtAnaHesapNo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(132, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Miktar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label7.ForeColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(122, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = " Ana Hesap Numarası";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label8.ForeColor = System.Drawing.Color.MistyRose;
            this.label8.Location = new System.Drawing.Point(132, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(425, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Havale Yapılacak Hesap Numarasi";
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Appearance.BackColor = System.Drawing.Color.BlueViolet;
            this.tabNavigationPage4.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage4.Caption = "Hesaplarım";
            this.tabNavigationPage4.Controls.Add(this.btnGeriDonList);
            this.tabNavigationPage4.Controls.Add(this.btnHesapListele);
            this.tabNavigationPage4.Controls.Add(this.dataGridHesaplar);
            this.tabNavigationPage4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage4.ImageOptions.SvgImage")));
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnGeriDonList
            // 
            this.btnGeriDonList.BackColor = System.Drawing.SystemColors.Window;
            this.btnGeriDonList.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnGeriDonList.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnGeriDonList.Location = new System.Drawing.Point(712, 473);
            this.btnGeriDonList.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDonList.Name = "btnGeriDonList";
            this.btnGeriDonList.Size = new System.Drawing.Size(204, 43);
            this.btnGeriDonList.TabIndex = 25;
            this.btnGeriDonList.Text = "Geri Dön";
            this.btnGeriDonList.UseVisualStyleBackColor = false;
            this.btnGeriDonList.Click += new System.EventHandler(this.btnGeriDonList_Click);
            // 
            // btnHesapListele
            // 
            this.btnHesapListele.BackColor = System.Drawing.SystemColors.Window;
            this.btnHesapListele.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnHesapListele.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnHesapListele.Location = new System.Drawing.Point(311, 473);
            this.btnHesapListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapListele.Name = "btnHesapListele";
            this.btnHesapListele.Size = new System.Drawing.Size(204, 43);
            this.btnHesapListele.TabIndex = 24;
            this.btnHesapListele.Text = "Listele";
            this.btnHesapListele.UseVisualStyleBackColor = false;
            this.btnHesapListele.Click += new System.EventHandler(this.btnHesapListele_Click);
            // 
            // dataGridHesaplar
            // 
            this.dataGridHesaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHesaplar.Location = new System.Drawing.Point(39, 30);
            this.dataGridHesaplar.Name = "dataGridHesaplar";
            this.dataGridHesaplar.RowHeadersWidth = 51;
            this.dataGridHesaplar.RowTemplate.Height = 24;
            this.dataGridHesaplar.Size = new System.Drawing.Size(1061, 406);
            this.dataGridHesaplar.TabIndex = 0;
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.tabNavigationPage5.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage5.Caption = "Hesap Ozeti";
            this.tabNavigationPage5.Controls.Add(this.btnOzetGeriDon);
            this.tabNavigationPage5.Controls.Add(this.dateTimeBitis);
            this.tabNavigationPage5.Controls.Add(this.dateTimeBaslangic);
            this.tabNavigationPage5.Controls.Add(this.btnOzetiListele);
            this.tabNavigationPage5.Controls.Add(this.txtHesapOzetNo);
            this.tabNavigationPage5.Controls.Add(this.label10);
            this.tabNavigationPage5.Controls.Add(this.dataGridOzet);
            this.tabNavigationPage5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage5.ImageOptions.SvgImage")));
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.Size = new System.Drawing.Size(1200, 547);
            // 
            // btnOzetGeriDon
            // 
            this.btnOzetGeriDon.BackColor = System.Drawing.Color.Teal;
            this.btnOzetGeriDon.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnOzetGeriDon.Location = new System.Drawing.Point(636, 483);
            this.btnOzetGeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnOzetGeriDon.Name = "btnOzetGeriDon";
            this.btnOzetGeriDon.Size = new System.Drawing.Size(204, 46);
            this.btnOzetGeriDon.TabIndex = 31;
            this.btnOzetGeriDon.Text = "Geri Dön";
            this.btnOzetGeriDon.UseVisualStyleBackColor = false;
            this.btnOzetGeriDon.Click += new System.EventHandler(this.btnOzetGeriDon_Click);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Location = new System.Drawing.Point(631, 53);
            this.dateTimeBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(236, 22);
            this.dateTimeBitis.TabIndex = 29;
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Location = new System.Drawing.Point(631, 21);
            this.dateTimeBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(236, 22);
            this.dateTimeBaslangic.TabIndex = 30;
            // 
            // btnOzetiListele
            // 
            this.btnOzetiListele.BackColor = System.Drawing.Color.Teal;
            this.btnOzetiListele.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnOzetiListele.Location = new System.Drawing.Point(163, 483);
            this.btnOzetiListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnOzetiListele.Name = "btnOzetiListele";
            this.btnOzetiListele.Size = new System.Drawing.Size(204, 46);
            this.btnOzetiListele.TabIndex = 28;
            this.btnOzetiListele.Text = "Listele";
            this.btnOzetiListele.UseVisualStyleBackColor = false;
            this.btnOzetiListele.Click += new System.EventHandler(this.btnOzetiListele_Click);
            // 
            // txtHesapOzetNo
            // 
            this.txtHesapOzetNo.Location = new System.Drawing.Point(383, 36);
            this.txtHesapOzetNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapOzetNo.Multiline = true;
            this.txtHesapOzetNo.Name = "txtHesapOzetNo";
            this.txtHesapOzetNo.Size = new System.Drawing.Size(203, 29);
            this.txtHesapOzetNo.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label10.Location = new System.Drawing.Point(133, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 30);
            this.label10.TabIndex = 26;
            this.label10.Text = "Hesap Numarası";
            // 
            // dataGridOzet
            // 
            this.dataGridOzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOzet.Location = new System.Drawing.Point(65, 101);
            this.dataGridOzet.Name = "dataGridOzet";
            this.dataGridOzet.RowHeadersWidth = 51;
            this.dataGridOzet.RowTemplate.Height = 24;
            this.dataGridOzet.Size = new System.Drawing.Size(922, 366);
            this.dataGridOzet.TabIndex = 0;
            // 
            // formMusteriIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMusteriIslem";
            this.Text = "formMusteriIslem";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            this.tabNavigationPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesaplar)).EndInit();
            this.tabNavigationPage5.ResumeLayout(false);
            this.tabNavigationPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOzet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.Button btnGeriDön;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.TextBox txtCekilmekIstenenPara;
        private System.Windows.Forms.TextBox txtHesapNumarasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerıDon;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.TextBox txtYatirilanPara;
        private System.Windows.Forms.TextBox txtParaHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnHavaleGönder;
        private System.Windows.Forms.TextBox txtHavaleMiktar;
        private System.Windows.Forms.TextBox txtHavaleHesapNo;
        private System.Windows.Forms.TextBox txtAnaHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private System.Windows.Forms.Button btnGeriDonList;
        private System.Windows.Forms.Button btnHesapListele;
        private System.Windows.Forms.DataGridView dataGridHesaplar;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
        private System.Windows.Forms.Button btnOzetGeriDon;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.Button btnOzetiListele;
        private System.Windows.Forms.TextBox txtHesapOzetNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridOzet;
    }
}