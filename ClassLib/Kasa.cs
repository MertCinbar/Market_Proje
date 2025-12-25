using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Kasa : BaseSatis
    {
        private double kasaToplam;
        public override double ToplamTutar
        {
            get { return kasaToplam; }
        }


        public override void Ekle(double tutar)
        {
            kasaToplam += tutar;
        }


        public override void Temizle()
        {
            kasaToplam = 0;
        }

    }
}

