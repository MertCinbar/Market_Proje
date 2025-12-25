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
    public partial class FormSepet : Form
    {
        public FormSepet()
        {
            InitializeComponent();
        }

        private void lblToplam_Click(object sender, EventArgs e)
        {

        }
        void Guncelle()
        {
            listSepet.Items.Clear();
            foreach (Urun u in OrtakAlan.AktifSiparis.Urunler)
            {
                listSepet.Items.Add(u.Ad + " - " + u.Fiyat + " TL");
            }
            lblToplam.Text = OrtakAlan.AktifSiparis.ToplamTutar + " TL";
        }

        void AramaYap(string aranan)
        {
            listSepet.Items.Clear();

            var sonuc = OrtakAlan.AktifSiparis.Urunler
                .Where(u => u.Ad.Contains(aranan.ToUpper()))
                .Select(u => $"{u.Ad} - {u.Fiyat} TL")
                .ToArray();

            listSepet.Items.AddRange(sonuc);
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            FormOdeme f = new FormOdeme(OrtakAlan.AktifSiparis.ToplamTutar);
            f.Show();
            this.Hide();
        }

        private void FormSepet_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int seciliIndex = listSepet.SelectedIndex;
            if (seciliIndex >= 0)
            {
                OrtakAlan.AktifSiparis.UrunSil(seciliIndex);
                Guncelle();
            }
            else
            {
                MessageBox.Show("Silmek için ürün seçiniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrtakAlan.AktifSiparis.Temizle();
            Guncelle();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim();

            if (string.IsNullOrEmpty(aranan))
                Guncelle();
            else
                AramaYap(aranan);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {
               

        }


    }
}
