using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace organizasyon_planlama_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void kodolustur()
        {
            Random rw = new Random();
            int sayi;
            sayi = rw.Next(10000, 1000000);
           
            textKod.Text = sayi.ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox_kullanici.Text == "Admin" && textBox_Sifre.Text == "123456" &&
                textKOD1.Text == textKod.Text)
            {
               Menu frm = new Menu();     //menu den nesne aldım
                frm.Show();
                this.Hide(); //üzerinde çalışrıgımız formu gizler

            }
            else
            {
                MessageBox.Show("Kullanıcı adı, şifre veya kod hatalı." +
                    "Tekrardan giriş yapınız", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şifre: 123456", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            kodolustur();
        }

        private void textBox_kullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textKOD1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
