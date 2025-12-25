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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBoxAd.Text;
            string sifre = textBoxSifre.Text;
            string rol = comboBoxRol.Text;

            Kullanici k = new Kullanici(ad,sifre,rol);
            string sonuc = k.GirisYap();

            if (sonuc == "OK")
            {
                MessageBox.Show("Giriş Başarılı");
                if (rol == "Yönetici")
                {
                    FormYonetici f = new FormYonetici();
                    f.Show();
                    this.Hide();
                }
                else if (rol == "Kasiyer")
                {
                    FormKasiyer f = new FormKasiyer();
                    f.Show();
                    this.Hide();
                }
                else if (rol == "Müşteri")
                {
                    FormMusteri f = new FormMusteri();
                    f.Show();
                    this.Hide();
                }

            }
            else
                MessageBox.Show("Hatalı Giriş");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
