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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }

        void UrunEkle(string ad, double fiyat)
        {
            OrtakAlan.AktifSiparis.Ekle(ad,fiyat);
            
        }

        void UrunDetayAc(string ad, double fiyat)
        {
            FormUrunDetay f = new FormUrunDetay(ad, fiyat);
            f.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void ekmekPictureBox_Click_1(object sender, EventArgs e)
        {

            UrunDetayAc("Ekmek", Fiyatlar.Ekmek);
        }

        private void milkPictureBox_Click_1(object sender, EventArgs e)
        {
            UrunDetayAc("Süt", Fiyatlar.Sut);
        }

        private void eggPictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Yumurta", Fiyatlar.Yumurta);
        }

        private void cheesePictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Peynir", Fiyatlar.Peynir);
        }

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Kola", Fiyatlar.Kola);
        }

        private void meyvePictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Meyve", Fiyatlar.Meyve);
        }

        private void cikoPictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Dondurma", Fiyatlar.Dondurma);
        }

        private void suPictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Su", Fiyatlar.Su);
        }

        private void sebzePictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Sebze", Fiyatlar.Sebze);
        }

        private void cipsPictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Cips", Fiyatlar.Cips);
        }
            
        private void deterjanPictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Deterjan", Fiyatlar.Deterjan);
        }

        private void sampPictureBox_Click(object sender, EventArgs e)
        {
            UrunDetayAc("Şampuan", Fiyatlar.Sampuan);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSepet f = new FormSepet();
            f.Show();
            this.Hide();
        }
    }
}
