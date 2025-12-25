namespace MarketSinif
{
    public class Kullanici
    {
        private string ad;
        private string sifre;
        private string rol;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public Kullanici(string ad, string sifre, string rol)
        {
            this.Ad = ad;
            this.Sifre = sifre;
            this.Rol = rol;
        }

        public string GirisYap(string girilenSifre)
        {
            if (this.Sifre == girilenSifre)
                return "Giriş başarılı. Hoşgeldiniz " + this.Ad + " (" + this.Rol + ")";
            else
                return "Hatalı şifre!";
        }
    }
}
