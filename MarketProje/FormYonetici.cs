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
    public partial class FormYonetici : Form
    {

        public FormYonetici()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yeniFiyat = Convert.ToDouble(txtYeniFiyat.Text);

            if (cmbUrun.Text == "Ekmek") Fiyatlar.Ekmek = yeniFiyat;
            else if (cmbUrun.Text == "Süt") Fiyatlar.Sut = yeniFiyat;
            else if (cmbUrun.Text == "Yumurta") Fiyatlar.Yumurta = yeniFiyat;
            else if (cmbUrun.Text == "Peynir") Fiyatlar.Peynir = yeniFiyat;
            else if (cmbUrun.Text == "Kola") Fiyatlar.Kola = yeniFiyat;
            else if (cmbUrun.Text == "Meyve") Fiyatlar.Meyve = yeniFiyat;
            else if (cmbUrun.Text == "Su") Fiyatlar.Su = yeniFiyat;
            else if (cmbUrun.Text == "Dondurma") Fiyatlar.Dondurma = yeniFiyat;
            else if (cmbUrun.Text == "Sebze") Fiyatlar.Sebze = yeniFiyat;
            else if (cmbUrun.Text == "Cips") Fiyatlar.Cips = yeniFiyat;
            else if (cmbUrun.Text == "Deterjan") Fiyatlar.Deterjan = yeniFiyat;
            else if (cmbUrun.Text == "Şampuan") Fiyatlar.Sampuan = yeniFiyat;

            MessageBox.Show("Fiyat Güncellendi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Yönetici")
                Kullanici.AdminSifre = txtYeniSifre.Text;

            else if (cmbRol.Text == "Kasiyer")
                Kullanici.KasiyerSifre = txtYeniSifre.Text;

            else if (cmbRol.Text == "Müşteri")
                Kullanici.MusteriSifre = txtYeniSifre.Text;

            MessageBox.Show("Şifre güncellendi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGiris f = new FormGiris();
            f.Show();
            this.Hide();
        }

        private void buttonRapor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kasa Toplamı : " + OrtakAlan.kasa.ToplamTutar + " TL");
        }
    }
}
