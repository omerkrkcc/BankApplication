using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDeneme2
{
    class Banka:IBankaMetotları,IRaporMetotları
    {
        public List<Personel> Personeller = new List<Personel>();
        public List<BireyselMusteri> BireyselMusteriler = new List<BireyselMusteri>();
        public List<TicariMusteri> TicariMusteriler = new List<TicariMusteri>();
        public List<Rapor> BankaRaporListesi = new List<Rapor>();
        public decimal toplamPara { get; set; }

        Personel personel;
        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        Rapor Rapor;
        string rapor;
        DateTime tarih;
        public void MusteriEkle(bool musteriTipi, string ad, string soyad, string ID, string sifre, DateTime tarih)
        {
            if (musteriTipi == true)
            {
                bireyselMusteri = new BireyselMusteri();

                this.bireyselMusteri.Ad = ad;
                this.bireyselMusteri.Soyad = soyad;
                this.bireyselMusteri.ID = ID;
                this.bireyselMusteri.Sifre = sifre;
                this.bireyselMusteri.Tarih = tarih;
                this.bireyselMusteri.MusteriTipi = "Bireysel";

                BireyselMusteriler.Add(bireyselMusteri);
                rapor = "" + ID + "ID Numaralı Bireysel müşteri başarıyla eklenmiştir";
                tarih = DateTime.Today;
                RaporEkle(rapor, tarih);
            }
            else
            {
                ticariMusteri = new TicariMusteri();

                ticariMusteri.Ad = ad;
                ticariMusteri.Soyad = soyad;
                ticariMusteri.ID = ID;
                ticariMusteri.Sifre = sifre;
                ticariMusteri.Tarih = tarih;
                ticariMusteri.MusteriTipi = "Ticari";

                TicariMusteriler.Add(ticariMusteri);
                rapor = "" + ID + "ID Numaralı Ticari müşteri başarıyla eklenmiştir";
                tarih = DateTime.Today;
                RaporEkle(rapor, tarih);
            }

        }

        public void PersonelEkle(string ad, string soyad, string ID, string sifre)
        {
            personel = new Personel();

            this.personel.Ad = ad;
            this.personel.Soyad = soyad;
            this.personel.ID = ID;
            this.personel.Sifre = sifre;

            Personeller.Add(personel);
            System.Windows.Forms.MessageBox.Show("" + ID + " Numaralı Personel Başarıyla Eklendi.");
            rapor = "" + ID + " Numaralı Personel Başarıyla Eklendi.";
            tarih = DateTime.Today;
            RaporEkle(rapor, tarih);
        }

        public void PersonelSil(string kullaniciAdi)
        {
            foreach (Personel personel in Personeller.ToList())
            {
                if (kullaniciAdi == personel.ID)
                {
                    Personeller.Remove(personel);
                }

                System.Windows.Forms.MessageBox.Show("" + kullaniciAdi + " Numaralı Personel Başarıyla Silindi.");
                rapor = "" + kullaniciAdi + " Numaralı Personel Başarıyla Silindi.";
                tarih = DateTime.Today;
                RaporEkle(rapor, tarih);
            }
        }
        public void RaporEkle(string rapor, DateTime tarih)
        {
            this.Rapor = new Rapor();
            this.Rapor.rapor = rapor;
            this.Rapor.IslemTarihi = tarih;
            BankaRaporListesi.Add(Rapor);
        }
    }
}

