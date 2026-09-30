namespace MarketProje
{
    partial class FormKasiyer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKasiyer));
            panel1 = new Panel();
            moneyLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            urunListBox = new ListBox();
            label2 = new Label();
            ekmekPictureBox = new PictureBox();
            milkPictureBox = new PictureBox();
            eggPictureBox = new PictureBox();
            cheesePictureBox = new PictureBox();
            colaPictureBox = new PictureBox();
            meyvePictureBox = new PictureBox();
            cikoPictureBox = new PictureBox();
            suPictureBox = new PictureBox();
            sebzePictureBox = new PictureBox();
            cipsPictureBox = new PictureBox();
            deterjanPictureBox = new PictureBox();
            sampPictureBox = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ekmekPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)milkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eggPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cheesePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meyvePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cikoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)suPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sebzePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cipsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deterjanPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sampPictureBox).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(moneyLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 435);
            panel1.TabIndex = 0;
            // 
            // moneyLabel
            // 
            moneyLabel.Dock = DockStyle.Bottom;
            moneyLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            moneyLabel.Location = new Point(0, 405);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(188, 30);
            moneyLabel.TabIndex = 4;
            moneyLabel.Text = "Fiyat : 0 TL";
            moneyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 112);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 0;
            label1.Text = "Market";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Resource1.market;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(urunListBox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(627, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 435);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(0, 370);
            button1.Name = "button1";
            button1.Size = new Size(188, 65);
            button1.TabIndex = 3;
            button1.Text = "Öde";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // urunListBox
            // 
            urunListBox.BackColor = SystemColors.Control;
            urunListBox.BorderStyle = BorderStyle.None;
            urunListBox.Dock = DockStyle.Top;
            urunListBox.Font = new Font("Segoe UI", 12F);
            urunListBox.ItemHeight = 28;
            urunListBox.Location = new Point(0, 30);
            urunListBox.Name = "urunListBox";
            urunListBox.Size = new Size(188, 336);
            urunListBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 30);
            label2.TabIndex = 2;
            label2.Text = "Ürünler";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ekmekPictureBox
            // 
            ekmekPictureBox.Cursor = Cursors.Hand;
            ekmekPictureBox.Image = Resource1.bread_food_4690__2_;
            ekmekPictureBox.Location = new Point(3, 0);
            ekmekPictureBox.Name = "ekmekPictureBox";
            ekmekPictureBox.Size = new Size(143, 109);
            ekmekPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ekmekPictureBox.TabIndex = 2;
            ekmekPictureBox.TabStop = false;
            ekmekPictureBox.Click += ekmekPictureBox_Click;
            // 
            // milkPictureBox
            // 
            milkPictureBox.Cursor = Cursors.Hand;
            milkPictureBox.Image = Resource1.milk_drink_icon_134147;
            milkPictureBox.Location = new Point(147, 0);
            milkPictureBox.Name = "milkPictureBox";
            milkPictureBox.Size = new Size(143, 109);
            milkPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            milkPictureBox.TabIndex = 3;
            milkPictureBox.TabStop = false;
            milkPictureBox.Click += milkPictureBox_Click;
            // 
            // eggPictureBox
            // 
            eggPictureBox.Cursor = Cursors.Hand;
            eggPictureBox.Image = Resource1.egg_icon_125749;
            eggPictureBox.Location = new Point(290, 0);
            eggPictureBox.Name = "eggPictureBox";
            eggPictureBox.Size = new Size(147, 109);
            eggPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            eggPictureBox.TabIndex = 4;
            eggPictureBox.TabStop = false;
            eggPictureBox.Click += eggPictureBox_Click;
            // 
            // cheesePictureBox
            // 
            cheesePictureBox.Cursor = Cursors.Hand;
            cheesePictureBox.Image = Resource1.cheese_food_5426;
            cheesePictureBox.Location = new Point(3, 110);
            cheesePictureBox.Name = "cheesePictureBox";
            cheesePictureBox.Size = new Size(143, 109);
            cheesePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cheesePictureBox.TabIndex = 5;
            cheesePictureBox.TabStop = false;
            cheesePictureBox.Click += cheesePictureBox_Click;
            // 
            // colaPictureBox
            // 
            colaPictureBox.Cursor = Cursors.Hand;
            colaPictureBox.Image = Resource1.soda_can_icon_125666;
            colaPictureBox.Location = new Point(147, 110);
            colaPictureBox.Name = "colaPictureBox";
            colaPictureBox.Size = new Size(143, 109);
            colaPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            colaPictureBox.TabIndex = 6;
            colaPictureBox.TabStop = false;
            colaPictureBox.Click += colaPictureBox_Click;
            // 
            // meyvePictureBox
            // 
            meyvePictureBox.Cursor = Cursors.Hand;
            meyvePictureBox.Image = Resource1.shop_supermarket_fruits_store_grocery_icon_229141;
            meyvePictureBox.Location = new Point(290, 110);
            meyvePictureBox.Name = "meyvePictureBox";
            meyvePictureBox.Size = new Size(147, 109);
            meyvePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            meyvePictureBox.TabIndex = 7;
            meyvePictureBox.TabStop = false;
            meyvePictureBox.Click += meyvePictureBox_Click;
            // 
            // cikoPictureBox
            // 
            cikoPictureBox.Cursor = Cursors.Hand;
            cikoPictureBox.Image = Resource1.ice_cream_icon_126068;
            cikoPictureBox.Location = new Point(3, 220);
            cikoPictureBox.Name = "cikoPictureBox";
            cikoPictureBox.Size = new Size(143, 109);
            cikoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cikoPictureBox.TabIndex = 8;
            cikoPictureBox.TabStop = false;
            cikoPictureBox.Click += cikoPictureBox_Click;
            // 
            // suPictureBox
            // 
            suPictureBox.Cursor = Cursors.Hand;
            suPictureBox.Image = Resource1.fresh_drink_bottle_water_mineral_beverage_icon_258825__1_;
            suPictureBox.Location = new Point(147, 220);
            suPictureBox.Name = "suPictureBox";
            suPictureBox.Size = new Size(143, 109);
            suPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            suPictureBox.TabIndex = 9;
            suPictureBox.TabStop = false;
            suPictureBox.Click += suPictureBox_Click;
            // 
            // sebzePictureBox
            // 
            sebzePictureBox.Cursor = Cursors.Hand;
            sebzePictureBox.Image = Resource1.picnicbasketfullofrawvegetables_114673;
            sebzePictureBox.Location = new Point(290, 220);
            sebzePictureBox.Name = "sebzePictureBox";
            sebzePictureBox.Size = new Size(147, 109);
            sebzePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            sebzePictureBox.TabIndex = 10;
            sebzePictureBox.TabStop = false;
            sebzePictureBox.Click += sebzePictureBox_Click;
            // 
            // cipsPictureBox
            // 
            cipsPictureBox.Cursor = Cursors.Hand;
            cipsPictureBox.Image = Resource1.french_fries_chips_potatoes_food_fast_food_icon_207923;
            cipsPictureBox.Location = new Point(3, 326);
            cipsPictureBox.Name = "cipsPictureBox";
            cipsPictureBox.Size = new Size(143, 109);
            cipsPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cipsPictureBox.TabIndex = 11;
            cipsPictureBox.TabStop = false;
            cipsPictureBox.Click += cipsPictureBox_Click;
            // 
            // deterjanPictureBox
            // 
            deterjanPictureBox.Cursor = Cursors.Hand;
            deterjanPictureBox.Image = Resource1.hygiene_cleaning_cleaner_clean_detergent_icon_224915;
            deterjanPictureBox.Location = new Point(147, 326);
            deterjanPictureBox.Name = "deterjanPictureBox";
            deterjanPictureBox.Size = new Size(143, 109);
            deterjanPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            deterjanPictureBox.TabIndex = 12;
            deterjanPictureBox.TabStop = false;
            deterjanPictureBox.Click += deterjanPictureBox_Click;
            // 
            // sampPictureBox
            // 
            sampPictureBox.Cursor = Cursors.Hand;
            sampPictureBox.Image = Resource1.grooming_salon_care_animal_pet_shampoo_cat_icon_260121;
            sampPictureBox.Location = new Point(290, 326);
            sampPictureBox.Name = "sampPictureBox";
            sampPictureBox.Size = new Size(147, 109);
            sampPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            sampPictureBox.TabIndex = 13;
            sampPictureBox.TabStop = false;
            sampPictureBox.Click += sampPictureBox_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(sampPictureBox);
            panel3.Controls.Add(deterjanPictureBox);
            panel3.Controls.Add(cipsPictureBox);
            panel3.Controls.Add(sebzePictureBox);
            panel3.Controls.Add(suPictureBox);
            panel3.Controls.Add(cikoPictureBox);
            panel3.Controls.Add(meyvePictureBox);
            panel3.Controls.Add(colaPictureBox);
            panel3.Controls.Add(cheesePictureBox);
            panel3.Controls.Add(eggPictureBox);
            panel3.Controls.Add(milkPictureBox);
            panel3.Controls.Add(ekmekPictureBox);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(188, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 435);
            panel3.TabIndex = 2;
            // 
            // FormKasiyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(815, 435);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKasiyer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Market";
            Load += FormKasiyer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ekmekPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)milkPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)eggPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cheesePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)colaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)meyvePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cikoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)suPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sebzePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cipsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)deterjanPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sampPictureBox).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListBox urunListBox;
        private Button button1;
        private Label moneyLabel;
        private PictureBox ekmekPictureBox;
        private PictureBox milkPictureBox;
        private PictureBox eggPictureBox;
        private PictureBox cheesePictureBox;
        private PictureBox colaPictureBox;
        private PictureBox meyvePictureBox;
        private PictureBox cikoPictureBox;
        private PictureBox suPictureBox;
        private PictureBox sebzePictureBox;
        private PictureBox cipsPictureBox;
        private PictureBox deterjanPictureBox;
        private PictureBox sampPictureBox;
        private Panel panel3;
    }
}
