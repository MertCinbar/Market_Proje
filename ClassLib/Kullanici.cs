using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Kullanici
    {
        private string ad;
        private string sifre;
        private string rol;

        public static string AdminSifre = "1234";
        public static string KasiyerSifre = "4321";
        public static string MusteriSifre = "1111";

        public string Ad
        {
            get { return ad; } set { ad = value; }
        }

        public string Sifre
        {
            get { return sifre; } set { sifre = value; }
        }
        public string Rol
        {
            get { return rol; } set { rol = value; }
        }

        public Kullanici(string ad , string sifre , string rol)
        {
            this.Ad = ad;
            this.Sifre = sifre;
            this.Rol = rol;
        }

        public string GirisYap()
        {
            if (this.Rol == "Yönetici" && this.Ad == "Admin" && this.Sifre == AdminSifre)
                return "OK";
            if (this.Rol == "Kasiyer" && this.Ad == "Kasiyer" && this.Sifre == KasiyerSifre)
                return "OK";
            if (this.Rol == "Müşteri" && this.Ad == "Müşteri" && this.Sifre == MusteriSifre )
                return "OK";

            else
                return "Hatalı Şifre";
        }
    }
}
