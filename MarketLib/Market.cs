using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib
{
    public class Market
    {
        private string marketAdi;
        private string adres;
        private int calisanSayisi;
        private double kasaToplami;

        public string MarketAdi
        {
            get 
            {
                return marketAdi; 
            }
            set
            {
                marketAdi = value;
            }
        }
        public string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }
        public int CalisanSayisi
        {
            get
            {
                return calisanSayisi;
            }
            set 
            {
                if (value >= 0) 
                    calisanSayisi = value;
            }
        }
        public double KasaToplami
        {
            get
            {
                return kasaToplami;
            }
            set
            {
                if (value >= 0) kasaToplami = value;
            }
        }
        public Market(string ad, string adres, int calisan)
        {
            this.MarketAdi = ad;
            this.Adres = adres;
            this.CalisanSayisi = calisan;
            this.KasaToplami = 0;
        }

        public string KasaEkle(double miktar)
        {
            this.KasaToplami += miktar;
            return "Kasaya " + miktar + " TL eklendi. Yeni bakiye: " + this.KasaToplami + " TL";
        }

        public string KasaAzalt(double miktar)
        {
            this.KasaToplami -= miktar;
            return "Kasadan " + miktar + " TL çıkarıldı. Yeni bakiye: " + this.KasaToplami + " TL";
        }

        public string MarketBilgi()
        {
            return "Market: " + this.MarketAdi + " | Çalışan Sayısı: " + this.CalisanSayisi + " | Kasa: " + this.KasaToplami + " TL";
        }
    }
}

