namespace ClassLib
{
    public class Urun
    {
        private string ad;
        private double fiyat;
        //private string kategori;
        public string Ad
        {
            get 
            { 
                return ad;
            }
            set 
            {
                ad = value.ToUpper();
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
                fiyat = value; 
            } 
        }
        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
            //this.Kategori = Kategori;
        }
    }
}
