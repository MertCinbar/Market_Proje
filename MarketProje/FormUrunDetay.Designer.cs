namespace MarketProje
{
    partial class FormUrunDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunDetay));
            lblUrunAdi = new Label();
            lblFiyat = new Label();
            btnSepeteEkle = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUrunAdi.Location = new Point(96, 203);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(165, 46);
            lblUrunAdi.TabIndex = 0;
            lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Elephant", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiyat.ForeColor = Color.ForestGreen;
            lblFiyat.Location = new Point(49, 48);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(285, 155);
            lblFiyat.TabIndex = 1;
            lblFiyat.Text = "19₺";
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Location = new Point(72, 270);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(238, 42);
            btnSepeteEkle.TabIndex = 4;
            btnSepeteEkle.Text = "Sepete Ekle";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 6;
            label1.Text = "Sadece";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1._1486071980_1_79325;
            pictureBox1.Location = new Point(407, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 274);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormUrunDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnSepeteEkle);
            Controls.Add(lblFiyat);
            Controls.Add(lblUrunAdi);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUrunDetay";
            Text = "FormUrunDetay";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUrunAdi;
        private Label lblFiyat;
        private Button btnSepeteEkle;
        private Label label1;
        private PictureBox pictureBox1;
    }
}