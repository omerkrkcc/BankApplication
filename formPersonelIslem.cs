using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaDeneme2
{
     partial class formPersonelIslem : Form
    {
        Banka banka;
        public formPersonelIslem(Banka banka)
        {
            this.banka = banka;
            InitializeComponent();
        }
        private void txtMusteriAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txtMusteriSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void btnMusteriOlustur_Click(object sender, EventArgs e)
        {
            string ad = txtMusteriAdi.Text;
            string soyad = txtMusteriSoyadi.Text;
            string kullaniciAdi = txtMusteriNumarasi.Text;
            string sifre = txtMusteriSifre.Text;
            DateTime tarih = dateTimeMusteri.Value;

            if (rBtnBireyselMusteri.Checked == true)
            {
                banka.MusteriEkle(true, ad, soyad, kullaniciAdi, sifre, tarih);
                MessageBox.Show(kullaniciAdi + "Kullanıcı adına sahip " + ad + " " + soyad + " kisisi bireysel musteri olarak bankaya eklenmiştir . ");
                string rapor = kullaniciAdi + "Kullanıcı adına sahip " + ad + " " + soyad + " kisisi bireysel musteri olarak bankaya eklenmiştir .";
                banka.RaporEkle(rapor, tarih);
            }
            else if (rBtnTicariMusteri.Checked == true)
            {
                banka.MusteriEkle(false, ad, soyad, kullaniciAdi, sifre, tarih);
                MessageBox.Show(kullaniciAdi + "Kullanıcı adına sahip " + ad + " " + soyad + " kisisi ticari musteri olarak bankaya eklenmiştir . ");
                string rapor = kullaniciAdi + "Kullanıcı adına sahip " + ad + " " + soyad + " kisisi Ticari musteri olarak bankaya eklenmiştir .";
                banka.RaporEkle(rapor, tarih);
            }
            else
            {
                MessageBox.Show("Lütfen müşteri tipini seçiniz.");
            }
        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            string musteriNumarasi = txtMusteriNo.Text;
            int ekBakiye = Convert.ToInt32(txtMusteriEkBakiye.Text);

            foreach (BireyselMusteri bireyselMusteri in banka.BireyselMusteriler)
            {
                if (musteriNumarasi == bireyselMusteri.ID)
                {
                    bireyselMusteri.HesapAc(ekBakiye);
                    MessageBox.Show(bireyselMusteri.ID + " kullanıcı adına sahip Bireysel Musteri için yeni hesap açılmıştır");
                    string rapor = bireyselMusteri.ID + " kullanıcı adına sahip Bireysel Musteri için yeni hesap açılmıştır";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }
            foreach (TicariMusteri ticariMusteri in banka.TicariMusteriler)
            {
                if (musteriNumarasi == ticariMusteri.ID)
                {
                    ticariMusteri.HesapAc(ekBakiye);
                    MessageBox.Show(ticariMusteri.ID + " kullanıcı adına sahip ticari Musteri için yeni hesap açılmıştır");
                    string rapor = ticariMusteri.ID + " kullanıcı adına sahip Bireysel Musteri için yeni hesap açılmıştır";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtHesapNumarasi.Text);

            foreach (BireyselMusteri bireyselMusteri in banka.BireyselMusteriler)
            {
                foreach (Hesap hesap in bireyselMusteri.Hesaplar.ToList())
                {
                    bireyselMusteri.HesapSil(hesapNo);
                    MessageBox.Show(bireyselMusteri.ID + " kullanıcı adına sahip Bireysel Musterinin   " + hesapNo + " numaralı hesabi silindi.");
                    string rapor = bireyselMusteri.ID + " kullanıcı adına sahip Bireysel Musterinin   " + hesapNo + " numaralı hesabi silindi.";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }

            }

            foreach (TicariMusteri ticariMusteri in banka.TicariMusteriler)
            {
                foreach (Hesap hesap in ticariMusteri.Hesaplar.ToList())
                {
                    ticariMusteri.HesapSil(hesapNo);
                    MessageBox.Show(ticariMusteri.ID + " kullanıcı adına sahip Bireysel Musterinin   " + hesapNo + " numaralı hesabi silindi.");
                    string rapor = ticariMusteri.ID + " kullanıcı adına sahip Ticari Musterinin   " + hesapNo + " numaralı hesabi silindi.";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }

            }
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            formAnaGirisEkrani formAnaGiris = new formAnaGirisEkrani(banka);
            formAnaGiris.TopLevel = false;
            panel1.Controls.Add(formAnaGiris);
            formAnaGiris.Show();
            formAnaGiris.Dock = DockStyle.Fill;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            formAnaGirisEkrani formAnaGiris = new formAnaGirisEkrani(banka);
            formAnaGiris.TopLevel = false;
            panel1.Controls.Add(formAnaGiris);
            formAnaGiris.Show();
            formAnaGiris.Dock = DockStyle.Fill;
        }

        private void btnGerıDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            formAnaGirisEkrani formAnaGiris = new formAnaGirisEkrani(banka);
            formAnaGiris.TopLevel = false;
            panel1.Controls.Add(formAnaGiris);
            formAnaGiris.Show();
            formAnaGiris.Dock = DockStyle.Fill;
        }
    }
}
