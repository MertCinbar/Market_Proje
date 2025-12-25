using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace MarketProje
{
    public partial class FormUrunDetay : Form
    {
        Urun urun;

        public FormUrunDetay(string ad, double fiyat)
        {
            InitializeComponent();

            urun = new Urun(ad, fiyat);
            lblUrunAdi.Text = urun.Ad;
            lblFiyat.Text = urun.Fiyat + " ₺";
        }

        
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            OrtakAlan.AktifSiparis.Ekle(urun.Ad,urun.Fiyat);
            MessageBox.Show("Ürün Sepete Eklendi");
            this.Close();
        }
    }
}
