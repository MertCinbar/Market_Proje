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
    public partial class FormOdeme : Form
    {
        double tutar;
        public FormOdeme(double toplam)
        {
            InitializeComponent();
            tutar = toplam;
        }

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            lblToplamTutar.Text = tutar + "TL";
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxNakit_Click(object sender, EventArgs e)
        {
            OrtakAlan.kasa.Ekle(tutar);
            OrtakAlan.AktifSiparis.Temizle();
            MessageBox.Show("Ödeme Alındı");

            FormGiris f = new FormGiris();
            f.Show();
            this.Close();
        }

        private void pictureBoxKart_Click(object sender, EventArgs e)
        {
            OrtakAlan.kasa.Ekle(tutar);
            OrtakAlan.AktifSiparis.Temizle();
            MessageBox.Show("Ödeme Alındı");

            FormGiris f = new FormGiris();
            f.Show();
            this.Close();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

        }
    }
}
