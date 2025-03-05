namespace organizasyon_planlama_sistemi
{
    partial class Görevliler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonEKLE = new System.Windows.Forms.Button();
            this.buttonSIL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.textBoxSOYAD = new System.Windows.Forms.TextBox();
            this.textBoxMAAS = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonCks = new System.Windows.Forms.Button();
            this.buttonAnaMnu = new System.Windows.Forms.Button();
            this.buttonGörevYeri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxResim = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(35, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(403, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orgonizasyon Görevlileri";
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.ForeColor = System.Drawing.Color.Purple;
            this.buttonListele.Location = new System.Drawing.Point(35, 181);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(216, 58);
            this.buttonListele.TabIndex = 1;
            this.buttonListele.Text = "Görevlileri Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonEKLE
            // 
            this.buttonEKLE.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEKLE.ForeColor = System.Drawing.Color.Purple;
            this.buttonEKLE.Location = new System.Drawing.Point(35, 620);
            this.buttonEKLE.Name = "buttonEKLE";
            this.buttonEKLE.Size = new System.Drawing.Size(255, 58);
            this.buttonEKLE.TabIndex = 8;
            this.buttonEKLE.Text = "Yeni Görevli Ekle";
            this.buttonEKLE.UseVisualStyleBackColor = true;
            this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click);
            // 
            // buttonSIL
            // 
            this.buttonSIL.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSIL.ForeColor = System.Drawing.Color.Purple;
            this.buttonSIL.Location = new System.Drawing.Point(341, 620);
            this.buttonSIL.Name = "buttonSIL";
            this.buttonSIL.Size = new System.Drawing.Size(224, 58);
            this.buttonSIL.TabIndex = 9;
            this.buttonSIL.Text = "Görevliyi Sil";
            this.buttonSIL.UseVisualStyleBackColor = true;
            this.buttonSIL.Click += new System.EventHandler(this.buttonSIL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(498, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Görevli ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(705, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(705, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(705, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon numarası:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(705, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Maaş Bilgisi";
            // 
            // textBoxAD
            // 
            this.textBoxAD.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAD.Location = new System.Drawing.Point(897, 286);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(184, 27);
            this.textBoxAD.TabIndex = 3;
            // 
            // textBoxSOYAD
            // 
            this.textBoxSOYAD.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSOYAD.Location = new System.Drawing.Point(897, 353);
            this.textBoxSOYAD.Name = "textBoxSOYAD";
            this.textBoxSOYAD.Size = new System.Drawing.Size(184, 27);
            this.textBoxSOYAD.TabIndex = 4;
            // 
            // textBoxMAAS
            // 
            this.textBoxMAAS.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMAAS.Location = new System.Drawing.Point(897, 529);
            this.textBoxMAAS.Name = "textBoxMAAS";
            this.textBoxMAAS.Size = new System.Drawing.Size(184, 27);
            this.textBoxMAAS.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(897, 446);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 30);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // buttonCks
            // 
            this.buttonCks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCks.ForeColor = System.Drawing.Color.Purple;
            this.buttonCks.Location = new System.Drawing.Point(1174, 779);
            this.buttonCks.Name = "buttonCks";
            this.buttonCks.Size = new System.Drawing.Size(132, 38);
            this.buttonCks.TabIndex = 12;
            this.buttonCks.Text = "Çıkış Yap";
            this.buttonCks.UseVisualStyleBackColor = true;
            this.buttonCks.Click += new System.EventHandler(this.buttonCks_Click);
            // 
            // buttonAnaMnu
            // 
            this.buttonAnaMnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnaMnu.ForeColor = System.Drawing.Color.Purple;
            this.buttonAnaMnu.Location = new System.Drawing.Point(1043, 779);
            this.buttonAnaMnu.Name = "buttonAnaMnu";
            this.buttonAnaMnu.Size = new System.Drawing.Size(125, 38);
            this.buttonAnaMnu.TabIndex = 11;
            this.buttonAnaMnu.Text = "Ana Menü";
            this.buttonAnaMnu.UseVisualStyleBackColor = true;
            this.buttonAnaMnu.Click += new System.EventHandler(this.buttonAnaMnu_Click);
            // 
            // buttonGörevYeri
            // 
            this.buttonGörevYeri.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGörevYeri.ForeColor = System.Drawing.Color.Purple;
            this.buttonGörevYeri.Location = new System.Drawing.Point(1046, 712);
            this.buttonGörevYeri.Name = "buttonGörevYeri";
            this.buttonGörevYeri.Size = new System.Drawing.Size(260, 61);
            this.buttonGörevYeri.TabIndex = 10;
            this.buttonGörevYeri.Text = "Organizasyon Rolleri";
            this.buttonGörevYeri.UseVisualStyleBackColor = true;
            this.buttonGörevYeri.Click += new System.EventHandler(this.buttonGörevYeri_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(810, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bilgileri Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxID.Location = new System.Drawing.Point(616, 181);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(184, 27);
            this.textBoxID.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(1089, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxResim
            // 
            this.textBoxResim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxResim.Location = new System.Drawing.Point(83, 722);
            this.textBoxResim.Name = "textBoxResim";
            this.textBoxResim.Size = new System.Drawing.Size(184, 27);
            this.textBoxResim.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(1035, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Görevliler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1318, 818);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxResim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGörevYeri);
            this.Controls.Add(this.buttonCks);
            this.Controls.Add(this.buttonAnaMnu);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBoxMAAS);
            this.Controls.Add(this.textBoxSOYAD);
            this.Controls.Add(this.textBoxAD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSIL);
            this.Controls.Add(this.buttonEKLE);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Görevliler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Görevliler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonEKLE;
        private System.Windows.Forms.Button buttonSIL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.TextBox textBoxSOYAD;
        private System.Windows.Forms.TextBox textBoxMAAS;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonCks;
        private System.Windows.Forms.Button buttonAnaMnu;
        private System.Windows.Forms.Button buttonGörevYeri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxResim;
        private System.Windows.Forms.Button button2;
    }
}