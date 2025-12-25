using ClassLib;

namespace MarketProje
{
    public partial class FormKasiyer : Form
    {
        public FormKasiyer()
        {
            InitializeComponent();
        }

        double toplam = 0;
        private void FormKasiyer_Load(object sender, EventArgs e)
        {
            urunListBox.Items.Clear();
        }
        void UrunEkle(string ad, double fiyat)
        {
            urunListBox.Items.Add(ad + " - " + fiyat + " TL");
            toplam += fiyat;
            moneyLabel.Text = "Fiyat : " + toplam + " TL";
        }

        private void ekmekPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Ekmek", Fiyatlar.Ekmek);

        }
        private void milkPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Süt", Fiyatlar.Sut);
            
        }
        private void eggPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Yumurta", Fiyatlar.Yumurta);

        }

        private void cheesePictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Peynir", Fiyatlar.Peynir);

        }
        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Kola", Fiyatlar.Kola);

        }
        private void meyvePictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Meyve", Fiyatlar.Meyve);

        }
        private void cikoPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Dondurma", Fiyatlar.Dondurma);

        }
        private void suPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Su", Fiyatlar.Su);

        }
        private void sebzePictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Sebze", Fiyatlar.Sebze);

        }
        private void cipsPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Cips", Fiyatlar.Cips);

        }
        private void deterjanPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Deterjan", Fiyatlar.Deterjan);

        }
        private void sampPictureBox_Click(object sender, EventArgs e)
        {
            UrunEkle("Þampuan", Fiyatlar.Sampuan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOdeme f = new FormOdeme(toplam);
            f.Show();
            this.Hide();

            urunListBox.Items.Clear();
            toplam = 0;
            moneyLabel.Text = "Fiyat : 0 TL";

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
