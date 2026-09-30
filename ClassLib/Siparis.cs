using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLib;


public class Siparis : BaseSatis
{
    private double toplam;
    public List<Urun> Urunler = new List<Urun>();

    public override double ToplamTutar
    {
        get { return toplam; }
    }
    public void Ekle(string urunAdi, double fiyat)
    {
        Urun u =new Urun(urunAdi, fiyat);
        Urunler.Add(u);
        toplam += fiyat;
    }
    public override void Ekle(double tutar)
    {
        toplam += tutar;
    }

    public void UrunSil(int index)
    {
        if (index >= 0 && index < Urunler.Count)
        {
            toplam -= Urunler[index].Fiyat;
            Urunler.RemoveAt(index);
        }
    }

    public override void Temizle()
    {
        toplam = 0;
        Urunler.Clear();
    }

}

