namespace MarketProje
{
    partial class FormSepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSepet));
            listSepet = new ListBox();
            lblToplam = new Label();
            btnUrunSil = new Button();
            button2 = new Button();
            btnOdeme = new Button();
            panel1 = new Panel();
            txtAra = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listSepet
            // 
            listSepet.BackColor = Color.FromArgb(224, 224, 224);
            listSepet.Dock = DockStyle.Fill;
            listSepet.FormattingEnabled = true;
            listSepet.Location = new Point(0, 0);
            listSepet.Name = "listSepet";
            listSepet.Size = new Size(807, 192);
            listSepet.TabIndex = 0;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplam.Location = new Point(332, 195);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(113, 38);
            lblToplam.TabIndex = 1;
            lblToplam.Text = "Toplam";
            lblToplam.Click += lblToplam_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(92, 227);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(161, 60);
            btnUrunSil.TabIndex = 2;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // button2
            // 
            button2.Location = new Point(523, 227);
            button2.Name = "button2";
            button2.Size = new Size(162, 60);
            button2.TabIndex = 3;
            button2.Text = "Sepeti Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnOdeme
            // 
            btnOdeme.Location = new Point(332, 273);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(113, 60);
            btnOdeme.TabIndex = 4;
            btnOdeme.Text = "Öde";
            btnOdeme.UseVisualStyleBackColor = true;
            btnOdeme.Click += btnOdeme_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(listSepet);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 192);
            panel1.TabIndex = 6;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(169, 402);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(125, 27);
            txtAra.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(30, 398);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 8;
            label1.Text = "Ürün Ara :";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(332, 385);
            button1.Name = "button1";
            button1.Size = new Size(113, 60);
            button1.TabIndex = 9;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSepet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 475);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtAra);
            Controls.Add(panel1);
            Controls.Add(btnOdeme);
            Controls.Add(button2);
            Controls.Add(btnUrunSil);
            Controls.Add(lblToplam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSepet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSepet";
            Load += FormSepet_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSepet;
        private Label lblToplam;
        private Button btnUrunSil;
        private Button button2;
        private Button btnOdeme;
        private Panel panel1;
        private TextBox txtAra;
        private Label label1;
        private Button button1;
    }
}