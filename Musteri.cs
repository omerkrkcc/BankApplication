using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDeneme2
{
    abstract class Musteri:Kisi,IMusteriMetotları
    {
        public List<Hesap> Hesaplar { get; set; }
        Hesap hesap;
        string Rapor;
        DateTime tarih;
        public string MusteriTipi { get; set; }
        public DateTime Tarih { get; set; }
        public Musteri()
        {
            this.Hesaplar = new List<Hesap>();
        }


















        public void HesapAc(int ekBakiye)
        {
            Random hesapNo = new Random();
            int sayi = hesapNo.Next(1000, 10000);

            this.hesap = new Hesap();
            hesap.hesapNumarasi = sayi;
            hesap.gunlukLimit = 750;
            hesap.bakiye = 0;
            hesap.ekBakiye = ekBakiye;
            hesap.ekBakiyeLimit = ekBakiye;
            this.Hesaplar.Add(hesap);

            System.Windows.Forms.MessageBox.Show("" + ID + " Numaralı müşterimiz için " + sayi + " numaralı hesabı " + ekBakiye + "ek bakiyesi ile açılmıştır.");
        }

        public void HesapParaCek(Hesap hesap, decimal miktar)
        {
            if (hesap.ekBakiye != 0 && hesap.ekBakiye > 0)
            {
                if (hesap.gunlukLimit != 0 && hesap.gunlukLimit > 0)
                {
                    if (hesap.gunlukLimit - miktar >= 0.00m)
                    {
                        if (hesap.bakiye >= miktar)
                        {
                            hesap.bakiye -= miktar;
                            hesap.gunlukLimit -= miktar;
                            System.Windows.Forms.MessageBox.Show("Hesabınızdan " + miktar + " TL çekilmiştir");
                            Rapor = "Hesabınızdan " + miktar + " TL çekilmiştir";
                            tarih = DateTime.Today;
                            hesap.RaporEkle(Rapor, tarih);
                        }
                        else if (hesap.bakiye > 0)
                        {
                            if ((miktar - hesap.bakiye) <= hesap.ekBakiye)
                            {
                                decimal bakiyedenCekilen, ekBakiyedenCekilen;
                                bakiyedenCekilen = hesap.bakiye;
                                hesap.bakiye = 0;
                                ekBakiyedenCekilen = miktar - bakiyedenCekilen;
                                hesap.ekBakiye -= ekBakiyedenCekilen;
                                hesap.gunlukLimit -= bakiyedenCekilen + ekBakiyedenCekilen;
                                System.Windows.Forms.MessageBox.Show("" + bakiyedenCekilen + " TL Bakiyeden , " + ekBakiyedenCekilen + "ek bakiyeden çekilmiştir.");
                                Rapor = bakiyedenCekilen + " TL Bakiyeden, " + ekBakiyedenCekilen + "ek bakiyeden çekilmiştir.";
                                tarih = DateTime.Today;
                                hesap.RaporEkle(Rapor, tarih);
                            }
                            else
                                System.Windows.Forms.MessageBox.Show("Ek bakiye limitiniz bu işlem için yeterli değildir");
                        }
                        else
                        {
                            if (hesap.ekBakiye >= miktar)
                            {
                                hesap.ekBakiye -= miktar;
                                hesap.gunlukLimit -= miktar;
                                System.Windows.Forms.MessageBox.Show("" + miktar + " TL Ek bakiyeden çekilmiştir");
                                Rapor = "" + miktar + " TL Ek bakiyeden çekilmiştir";
                                tarih = DateTime.Today;
                                hesap.RaporEkle(Rapor, tarih);
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Bakiye ve ek bakiye bu işlem için yetersizdir.");
                            }
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Çekmek istediğiniz miktar kalan günlük para çekme limitinizden fazla olamaz. ");

                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Günlük para çekme limitiniz dolmuştur.");

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Bakiye ve ek bakiyeniz 0 iken işlem yapamazsınız.");

            }
        }

        public void HesapParaYatir(Hesap hesap, decimal miktar)
        {
            decimal odenenBorc = 0;
            hesap.bakiye += miktar;
            System.Windows.Forms.MessageBox.Show("Hesabınıza '" + miktar + "' TL eklenmiştir. \n Mevcut bakiye '" + hesap.bakiye + "' TL");
            Rapor = ("'" + miktar + "' TL yatırıldı.");
            tarih = DateTime.Today;
            hesap.RaporEkle(Rapor, tarih);//Hesap Özetine yapılan işlem ve tarihi gönderiliyor

            if (hesap.ekBakiye < hesap.ekBakiyeLimit)//Ekbakiye borcu varsa
            {

                decimal borc = hesap.ekBakiyeLimit - hesap.ekBakiye;

                for (decimal i = hesap.ekBakiye; hesap.ekBakiye < hesap.ekBakiyeLimit; i += 0.1m)//Ekbakiye borcu varsa para yatırırken otomatik olarak borç ödenir
                {
                    if (hesap.bakiye == 0.0m) { break; }
                    else
                    {

                        hesap.bakiye -= 0.1m;
                        odenenBorc += 0.1m;
                        hesap.ekBakiye += 0.1m;

                    }
                }
                System.Windows.Forms.MessageBox.Show("'" + borc + "' TL olan ek bakiye borcunuzun '" + odenenBorc + "' TL kadarı bakiyenizden tahsil edilmiştir.");
                Rapor = "'" + borc + "' TL olan ek bakiye borcunuzun '" + odenenBorc + "' TL kadarı bakiyenizden tahsil edilmiştir.";
                tarih = DateTime.Today;
                hesap.RaporEkle(Rapor, tarih);
            }
        }

        public void HesapSil(int hesapNo)
        {
            foreach (Hesap hesap in Hesaplar.ToList())
            {
                if (hesapNo == hesap.hesapNumarasi)
                {
                    if (hesap.bakiye == 0 && hesap.ekBakiye == hesap.ekBakiyeLimit) //Hesapta para yoksa ve ekBakiye borcu yoksa
                    {
                        Hesaplar.Remove(hesap);
                        System.Windows.Forms.MessageBox.Show("'" + hesapNo + "' numaralı hesap başarıyla silindi.");
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("'" + hesapNo + "' numaralı hesap silinebilmesi için bakiyesi 0 TL ve ek bakiye borcu olmamalıdır. \n Mevcut Bakiye: '" + hesap.bakiye + "' TL \n Güncel borç: '" + (hesap.ekBakiyeLimit - hesap.ekBakiye + "' TL"));
                }
            }
        }
    }
}
