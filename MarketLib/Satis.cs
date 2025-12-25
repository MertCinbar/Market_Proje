using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib
{
    public class Satis
    {
        private string urunAdi;
        private double fiyat;
        private string musteriAdi;
        private string tarih;

        public string UrunAdi
        {
            get {
                return urunAdi;
            }
            set
            {
                urunAdi = value.ToUpper();
            }
        }

        public double Fiyat
        {
            get
            { 
                return fiyat;
            }
            set
            {
                if (value >= 0) fiyat = value;
            }
        }

        public string MusteriAdi
        {
            get
            {
                return musteriAdi; 
            }
            set
            {
                musteriAdi = value;
            }
        }

        public string Tarih
        {
            get
            {
                return tarih;
            }
            set
            {
                tarih = value;
            }
        }

        public Satis(string urunAdi, double fiyat, string musteriAdi, string tarih)
        {
            this.UrunAdi = urunAdi;
            this.Fiyat = fiyat;
            this.MusteriAdi = musteriAdi;
            this.Tarih = tarih;
        }

        public string SatisYap()
        {
            return this.MusteriAdi + " adlı müşteri " + this.UrunAdi + " aldı. (" + this.Fiyat + " TL)";
        }

        public string IadeAl()
        {
            return this.MusteriAdi + " adlı müşterinin " + this.UrunAdi + " iadesi alındı.";
        }
    }
}

