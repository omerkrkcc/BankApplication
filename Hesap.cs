using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDeneme2
{
    class Hesap:IRaporMetotları
    {
        public int hesapNumarasi { get; set; }
        public decimal gunlukLimit { get; set; }
        public decimal bakiye { get; set; }
        public decimal ekBakiye { get; set; }
        public decimal ekBakiyeLimit { get; set; }
        public List<Rapor> raporListesi { get; set; }
        Rapor rapor;
        public Hesap()
        {
            this.raporListesi = new List<Rapor>();
        }
        public void RaporEkle(string rapor, DateTime IslemTarihi)
        {
            this.rapor = new Rapor();
            this.rapor.rapor = rapor;
            this.rapor.IslemTarihi = IslemTarihi;
            raporListesi.Add(this.rapor);
        }
    }
}

