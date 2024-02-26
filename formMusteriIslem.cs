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
     partial class formMusteriIslem : Form
    {

        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        Banka banka;
        bool musteri;
        public formMusteriIslem(Banka banka, BireyselMusteri bireyselMusteri)
        {
            InitializeComponent();
            this.banka = banka;
            this.bireyselMusteri = bireyselMusteri;
            this.musteri = true;
        }
        public formMusteriIslem(Banka banka, TicariMusteri ticariMusteri)
        {
            InitializeComponent();
            this.banka = banka;
            this.ticariMusteri = ticariMusteri;
            this.musteri = false;
        }
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtHesapNumarasi.Text);
            decimal miktar = Convert.ToDecimal(txtCekilmekIstenenPara.Text);

            foreach (BireyselMusteri bireyselMusteri in banka.BireyselMusteriler)
            {
                foreach (Hesap hesap in bireyselMusteri.Hesaplar)
                {
                    if (hesapNo == hesap.hesapNumarasi)
                        bireyselMusteri.HesapParaCek(hesap, miktar);
                }

            }
            foreach (TicariMusteri ticariMusteri in banka.TicariMusteriler)
            {

                foreach (Hesap hesap in ticariMusteri.Hesaplar)
                {
                    if (hesapNo == hesap.hesapNumarasi)
                        ticariMusteri.HesapParaCek(hesap, miktar);
                }

            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtParaHesapNo.Text);
            decimal miktar = Convert.ToDecimal(txtYatirilanPara.Text);

            foreach (BireyselMusteri bireyselMusteri in banka.BireyselMusteriler)
            {
                foreach (Hesap hesap in bireyselMusteri.Hesaplar)
                {
                    if (hesapNo == hesap.hesapNumarasi)
                        bireyselMusteri.HesapParaYatir(hesap, miktar);

                }

            }
            foreach (TicariMusteri ticariMusteri in banka.TicariMusteriler)
            {
                foreach (Hesap hesap in ticariMusteri.Hesaplar)
                {
                    if (hesapNo == hesap.hesapNumarasi)
                        ticariMusteri.HesapParaYatir(hesap, miktar);

                }

            }
        }

        private void btnHavaleGönder_Click(object sender, EventArgs e)
        {
            int anaHesapNo = Convert.ToInt32(txtAnaHesapNo.Text);
            int gonderilenHesapNo = Convert.ToInt32(txtHavaleHesapNo.Text);
            int miktar = Convert.ToInt32(txtHavaleMiktar.Text);
            decimal bankaPayi = 0.0m, hedefPayi = 0.0m;
            decimal islemOrani = 0.0m;

            Hesap anaHesap = null, gonderilenHesap = null;
            Musteri anaMusteri = null;
            bool anaDurum = false, gonderilenDurum = false, anaHesapTuru = false;

            foreach (BireyselMusteri bireyselMusteri in banka.BireyselMusteriler) //ana hesap bireysel müşteri 
            {
                foreach (Hesap hesap in bireyselMusteri.Hesaplar)
                {
                    if (anaHesapNo == hesap.hesapNumarasi)
                    {
                        anaHesap = hesap;//ana hesabı buluyoruz
                        anaMusteri = bireyselMusteri;//ana müşteriyi buluyoruz
                        anaDurum = true;
                        anaHesapTuru = true;
                    }
                    if (gonderilenHesapNo == hesap.hesapNumarasi)
                    {
                        gonderilenHesap = hesap;//havale  yapılacak  hesabı buluyoruz
                        anaMusteri = bireyselMusteri;///havale  yapılacak  müşteriyi buluyoruz
                        gonderilenDurum = true;
                    }
                }
            }
            foreach (TicariMusteri ticariMusteri in banka.TicariMusteriler)//ana hesap ticari müşteri ise
            {
                foreach (Hesap hesap in ticariMusteri.Hesaplar)
                {
                    if (anaHesapNo == hesap.hesapNumarasi)
                    {
                        anaHesap = hesap;
                        anaMusteri = ticariMusteri;
                        anaDurum = true;

                    }
                    if (anaHesapNo == hesap.hesapNumarasi)
                    {
                        gonderilenHesap = hesap;
                        anaMusteri = ticariMusteri;
                        gonderilenDurum = true;
                    }
                }
            }

            if (anaDurum == true && gonderilenDurum == true)//ana ve /havale  yapılacak  hesap numaraları bulunduysa
            {
                if (anaHesap.bakiye >= miktar)
                {
                    if (anaHesapTuru == true)
                        islemOrani = 2.0m;

                    anaHesap.bakiye -= miktar;
                    bankaPayi = (miktar * islemOrani) / 100;
                    hedefPayi = miktar - bankaPayi;
                    gonderilenHesap.bakiye += hedefPayi;
                    banka.toplamPara += bankaPayi;
                    MessageBox.Show("Hedef hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL");

                    string rapor = anaHesapNo + " numaralı hesaptan " + gonderilenHesapNo + " numaralı hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);

                    rapor = anaHesapNo + " numaralı hesabınızdan " + gonderilenHesapNo + " numaralı hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL";
                    anaHesap.RaporEkle(rapor, tarih);

                    rapor = anaHesapNo + " numaralı hesaptan " + gonderilenHesapNo + " numaralı hesabınıza " + hedefPayi + " TL aktarılmıştır.";
                    gonderilenHesap.RaporEkle(rapor, tarih);
                }

            }
            else
                MessageBox.Show("Lütfen Hedef ve Kaynak hesap numaralarını kontrol ediniz.");
        }

        private void btnHesapListele_Click(object sender, EventArgs e)
        {
            if (musteri == true) //Giriş yapan bireysel müşteri ise
                dataGridHesaplar.DataSource = bireyselMusteri.Hesaplar;
            else
                dataGridHesaplar.DataSource = ticariMusteri.Hesaplar;
        }

        private void btnOzetiListele_Click(object sender, EventArgs e)
        {
            int hesapNo = 0;
            if (txtHesapOzetNo.Text != "")//Hesap Özeti Listeleme  boş bırakılırsa hata vermemesi için
            {
                hesapNo = Convert.ToInt32(txtHesapOzetNo.Text);

                DateTime timeBaslangic = dateTimeBaslangic.Value;
                DateTime timeBitis = dateTimeBitis.Value;

                int BaslangicGun = timeBaslangic.Day;
                int BitisGun = timeBitis.Day;

                List<Rapor> raporListesi = new List<Rapor>();
                foreach (BireyselMusteri bireyselMusteri in banka.BireyselMusteriler)
                {
                    foreach (Hesap hesap in bireyselMusteri.Hesaplar)
                    {
                        if (hesapNo == hesap.hesapNumarasi)
                        {
                            foreach (Rapor rapor in hesap.raporListesi)
                            {
                                TimeSpan t = timeBitis - rapor.IslemTarihi;//Seçilen bitiş tarihi ile işlem tarihi arasındaki farkı alıyoruz.
                                int baslangicDegeri = t.Days; //Farkı güne çeviriyoruz.
                                TimeSpan t2 = rapor.IslemTarihi - timeBaslangic;
                                int bitisDegeri = t2.Days;

                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)//Eğer ki farklar - değer değilse yani belirtilen aralık arasındaysa 
                                {
                                    raporListesi.Add(rapor);
                                }
                            }
                        }
                    }

                }
                foreach (TicariMusteri ticariMusteri in banka.TicariMusteriler)
                {

                    foreach (Hesap hesap in ticariMusteri.Hesaplar)
                    {
                        if (hesapNo == hesap.hesapNumarasi)
                        {
                            foreach (Rapor rapor in hesap.raporListesi)
                            {
                                TimeSpan t = timeBitis - rapor.IslemTarihi;
                                int baslangicDegeri = t.Days;
                                TimeSpan t2 = rapor.IslemTarihi - timeBaslangic;
                                int bitisDegeri = t2.Days;
                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)
                                {
                                    raporListesi.Add(rapor);
                                }
                            }
                        }
                    }

                }
                dataGridOzet.DataSource = raporListesi;
            }
            else
                MessageBox.Show("Lütfen hesap numarası giriniz.");
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

        private void btnGeriDonList_Click(object sender, EventArgs e)
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

        private void btnOzetGeriDon_Click(object sender, EventArgs e)
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
