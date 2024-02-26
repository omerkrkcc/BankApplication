using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDeneme2
{
    interface IMusteriMetotları
    {
        void HesapAc(int ekBakiye);
        void HesapSil(int hesapNo);
        void HesapParaYatir(Hesap hesap, decimal miktar);
        void HesapParaCek(Hesap hesap, decimal miktar);
    }
}
