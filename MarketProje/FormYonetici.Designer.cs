namespace MarketProje
{
    partial class FormYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYonetici));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            buttonRapor = new Button();
            button5 = new Button();
            txtYeniFiyat = new TextBox();
            label3 = new Label();
            groupBoxUrun = new GroupBox();
            label1 = new Label();
            cmbUrun = new ComboBox();
            groupBoxKullanici = new GroupBox();
            label2 = new Label();
            cmbRol = new ComboBox();
            label5 = new Label();
            txtYeniSifre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxUrun.SuspendLayout();
            groupBoxKullanici.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.masculine_user_with_suit_tie_and_locked_padlock_icon_icons_com_68295;
            pictureBox1.Location = new Point(601, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 287);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(88, 184);
            button1.Name = "button1";
            button1.Size = new Size(145, 45);
            button1.TabIndex = 0;
            button1.Text = "Fiyat Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(370, 184);
            button2.Name = "button2";
            button2.Size = new Size(143, 45);
            button2.TabIndex = 1;
            button2.Text = "Rol Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonRapor
            // 
            buttonRapor.Location = new Point(240, 315);
            buttonRapor.Name = "buttonRapor";
            buttonRapor.Size = new Size(145, 58);
            buttonRapor.TabIndex = 2;
            buttonRapor.Text = "Kasa Rapor";
            buttonRapor.UseVisualStyleBackColor = true;
            buttonRapor.Click += buttonRapor_Click;
            // 
            // button5
            // 
            button5.Location = new Point(664, 389);
            button5.Name = "button5";
            button5.Size = new Size(145, 35);
            button5.TabIndex = 4;
            button5.Text = "Geri";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtYeniFiyat
            // 
            txtYeniFiyat.Location = new Point(99, 73);
            txtYeniFiyat.Name = "txtYeniFiyat";
            txtYeniFiyat.Size = new Size(151, 27);
            txtYeniFiyat.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 76);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 9;
            label3.Text = "Yeni Fiyat";
            // 
            // groupBoxUrun
            // 
            groupBoxUrun.Controls.Add(label1);
            groupBoxUrun.Controls.Add(cmbUrun);
            groupBoxUrun.Controls.Add(label3);
            groupBoxUrun.Controls.Add(txtYeniFiyat);
            groupBoxUrun.Location = new Point(43, 27);
            groupBoxUrun.Name = "groupBoxUrun";
            groupBoxUrun.Size = new Size(260, 151);
            groupBoxUrun.TabIndex = 12;
            groupBoxUrun.TabStop = false;
            groupBoxUrun.Text = "Ürün Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 14;
            label1.Text = "Ürün";
            // 
            // cmbUrun
            // 
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Items.AddRange(new object[] { "Ekmek", "Süt", "Yumurta", "Peynir", "Kola ", "Meyve", "Dondurma", "Su", "Sebze", "Cips", "Deterjan", "Şampuan" });
            cmbUrun.Location = new Point(99, 39);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(151, 28);
            cmbUrun.TabIndex = 13;
            // 
            // groupBoxKullanici
            // 
            groupBoxKullanici.Controls.Add(label2);
            groupBoxKullanici.Controls.Add(cmbRol);
            groupBoxKullanici.Controls.Add(label5);
            groupBoxKullanici.Controls.Add(txtYeniSifre);
            groupBoxKullanici.Location = new Point(326, 27);
            groupBoxKullanici.Name = "groupBoxKullanici";
            groupBoxKullanici.Size = new Size(260, 151);
            groupBoxKullanici.TabIndex = 15;
            groupBoxKullanici.TabStop = false;
            groupBoxKullanici.Text = "Kullanıcılar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 42);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 14;
            label2.Text = "Roller";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Yönetici", "Kasiyer", "Müşteri" });
            cmbRol.Location = new Point(99, 39);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 76);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(99, 73);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(151, 27);
            txtYeniSifre.TabIndex = 8;
            // 
            // FormYonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(888, 464);
            Controls.Add(groupBoxKullanici);
            Controls.Add(groupBoxUrun);
            Controls.Add(button5);
            Controls.Add(buttonRapor);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormYonetici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yonetici Penceresi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxUrun.ResumeLayout(false);
            groupBoxUrun.PerformLayout();
            groupBoxKullanici.ResumeLayout(false);
            groupBoxKullanici.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonRapor;
        private Button button2;
        private Button button1;
        private Button button5;
        private TextBox txtYeniFiyat;
        private Label label3;
        private GroupBox groupBoxUrun;
        private ComboBox cmbUrun;
        private Label label1;
        private GroupBox groupBoxKullanici;
        private Label label2;
        private ComboBox cmbRol;
        private Label label5;
        private TextBox txtYeniSifre;
    }
}