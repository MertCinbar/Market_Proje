using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public abstract class BaseSatis : ISatis
    {
        public abstract double ToplamTutar { get; }

        public virtual void Ekle(double tutar) { }

        public virtual void Temizle() { }
    }
}
