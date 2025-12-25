namespace MarketLib
{
    public class Urun
    {
        private string urunAdi;
        private double fiyat;
        private string kategori;
        public string UrunAdi
        {
            get 
            {
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
        public string Kategori
        {
            get
            {
                return kategori;
            }
            set
            {
                kategori = value; 
            }
        }
        
        public Urun(string ad, double fiyat, string kategori)
        {
            this.UrunAdi = ad;
            this.Fiyat = fiyat;
            this.Kategori = kategori;
        }

       
        public UrunBilgisiGoster()
        {
            return "Ürün: " + this.UrunAdi + " | Fiyat: " + this.Fiyat + " TL | Kategori: " + this.Kategori;
        }
    }
}
