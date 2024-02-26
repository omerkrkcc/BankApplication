﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDeneme2
{
    public interface IBankaMetotları
    {
        void MusteriEkle(bool musteriTipi, string ad, string soyad, string ID, string sifre, DateTime tarih);
        void PersonelEkle(string ad, string soyad, string ID, string sifre);
        void PersonelSil(string kullaniciAdi);

    }
}
