namespace organizasyon_planlama_sistemi
{
    partial class EKLEFRM
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
            this.buttonCks = new System.Windows.Forms.Button();
            this.buttonGERİ = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxMAAS = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSYD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonResimSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxResim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCks
            // 
            this.buttonCks.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCks.ForeColor = System.Drawing.Color.Purple;
            this.buttonCks.Location = new System.Drawing.Point(781, 586);
            this.buttonCks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(169, 50);
            this.buttonCks.TabIndex = 42;
            this.buttonCks.Text = " Çıkış Yap";
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // buttonGERİ
            // 
            this.buttonGERİ.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGERİ.ForeColor = System.Drawing.Color.Purple;
            this.buttonGERİ.Location = new System.Drawing.Point(557, 586);
            this.buttonGERİ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGERİ.Name = "buttonGERİ";
            this.buttonGERİ.Size = new System.Drawing.Size(169, 50);
            this.buttonGERİ.TabIndex = 41;
            this.buttonGERİ.Text = "GERİ";
            this.buttonGERİ.UseVisualStyleBackColor = true;
            this.buttonGERİ.Click += new System.EventHandler(this.buttonGERİ_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.Color.Purple;
            this.buttonEkle.Location = new System.Drawing.Point(321, 586);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(141, 54);
            this.buttonEkle.TabIndex = 40;
            this.buttonEkle.Text = " Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(325, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = " YENİ PERSONEL EKLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(87, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxMAAS
            // 
            this.textBoxMAAS.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMAAS.Location = new System.Drawing.Point(686, 481);
            this.textBoxMAAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMAAS.Name = "textBoxMAAS";
            this.textBoxMAAS.Size = new System.Drawing.Size(169, 27);
            this.textBoxMAAS.TabIndex = 36;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(686, 383);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(169, 24);
            this.maskedTextBox1.TabIndex = 34;
            // 
            // textBoxSYD
            // 
            this.textBoxSYD.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSYD.Location = new System.Drawing.Point(686, 242);
            this.textBoxSYD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSYD.Name = "textBoxSYD";
            this.textBoxSYD.Size = new System.Drawing.Size(169, 27);
            this.textBoxSYD.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(525, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(525, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(525, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Soyadı:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(686, 157);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(169, 27);
            this.textBoxAd.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(525, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Adı:";
            // 
            // buttonResimSec
            // 
            this.buttonResimSec.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonResimSec.ForeColor = System.Drawing.Color.Purple;
            this.buttonResimSec.Location = new System.Drawing.Point(97, 586);
            this.buttonResimSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonResimSec.Name = "buttonResimSec";
            this.buttonResimSec.Size = new System.Drawing.Size(142, 54);
            this.buttonResimSec.TabIndex = 39;
            this.buttonResimSec.Text = "Resim Seç";
            this.buttonResimSec.UseVisualStyleBackColor = true;
            this.buttonResimSec.Click += new System.EventHandler(this.buttonResimSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxResim
            // 
            this.textBoxResim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxResim.Location = new System.Drawing.Point(741, 80);
            this.textBoxResim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResim.Name = "textBoxResim";
            this.textBoxResim.Size = new System.Drawing.Size(169, 27);
            this.textBoxResim.TabIndex = 40;
            // 
            // EKLEFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(981, 678);
            this.Controls.Add(this.textBoxResim);
            this.Controls.Add(this.buttonResimSec);
            this.Controls.Add(this.textBoxMAAS);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBoxSYD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.buttonGERİ);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EKLEFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EKLEFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button buttonGERİ;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxMAAS;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBoxSYD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonResimSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxResim;
    }
}