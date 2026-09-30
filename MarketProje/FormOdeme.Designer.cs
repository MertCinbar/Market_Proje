namespace MarketProje
{
    partial class FormOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdeme));
            lblToplamTutar = new Label();
            pictureBoxNakit = new PictureBox();
            pictureBoxKart = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNakit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKart).BeginInit();
            SuspendLayout();
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToplamTutar.Location = new Point(348, 26);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(138, 46);
            lblToplamTutar.TabIndex = 0;
            lblToplamTutar.Text = "Toplam";
            // 
            // pictureBoxNakit
            // 
            pictureBoxNakit.Image = (Image)resources.GetObject("pictureBoxNakit.Image");
            pictureBoxNakit.Location = new Point(133, 94);
            pictureBoxNakit.Name = "pictureBoxNakit";
            pictureBoxNakit.Size = new Size(256, 256);
            pictureBoxNakit.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxNakit.TabIndex = 4;
            pictureBoxNakit.TabStop = false;
            pictureBoxNakit.Click += pictureBoxNakit_Click;
            // 
            // pictureBoxKart
            // 
            pictureBoxKart.Image = (Image)resources.GetObject("pictureBoxKart.Image");
            pictureBoxKart.Location = new Point(457, 94);
            pictureBoxKart.Name = "pictureBoxKart";
            pictureBoxKart.Size = new Size(256, 256);
            pictureBoxKart.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxKart.TabIndex = 5;
            pictureBoxKart.TabStop = false;
            pictureBoxKart.Click += pictureBoxKart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(219, 375);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 6;
            label1.Text = "NAKİT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(561, 375);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 7;
            label2.Text = "KART";
            // 
            // FormOdeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxKart);
            Controls.Add(pictureBoxNakit);
            Controls.Add(lblToplamTutar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOdeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOdeme";
            Load += FormOdeme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxNakit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblToplamTutar;
        private PictureBox pictureBoxNakit;
        private PictureBox pictureBoxKart;
        private Label label1;
        private Label label2;
    }
}