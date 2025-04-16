using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketKasaApp
{
    public class Sepet
    {
        public Sepet()
        {
            
        }

        public Sepet(string urunAdi,int kilo,decimal kiloFiyati)
        {
            this.Urunadi = urunAdi;
            this.Kilo = kilo;   
            this.KiloFiyati = kiloFiyati;
            this.Toplam = kilo*kiloFiyati;   
            
        }

        public string Urunadi { get; set; }

        public int Kilo { get; set; }

        public decimal KiloFiyati { get; set; }

        public decimal Toplam { get; set; }

    }
}
