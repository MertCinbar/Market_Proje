namespace MarketProje
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            label1 = new Label();
            label2 = new Label();
            textBoxAd = new TextBox();
            textBoxSifre = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            comboBoxRol = new ComboBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 52);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 98);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(157, 49);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(151, 27);
            textBoxAd.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(157, 98);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(151, 27);
            textBoxSifre.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSifre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxRol);
            groupBox1.Controls.Add(textBoxAd);
            groupBox1.Location = new Point(53, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 274);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Girişi";
            // 
            // button1
            // 
            button1.Location = new Point(134, 211);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 6;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 148);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 5;
            label3.Text = "Rol";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Yönetici", "Kasiyer", "Müşteri" });
            comboBoxRol.Location = new Point(157, 148);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(151, 28);
            comboBoxRol.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Resource1.lockicon_120641;
            pictureBox1.Location = new Point(460, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            Load += FormGiris_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxAd;
        private TextBox textBoxSifre;
        private GroupBox groupBox1;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private ComboBox comboBoxRol;
    }
}