using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organizasyon_planlama_sistemi
{
    public partial class EKLEFRM : Form
    {
        public EKLEFRM()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("INSERT INTO calisan_table(clsn_AD,clsn_SOYAD,clsn_TEL,clsn_maas,Resim) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            Komut.Parameters.AddWithValue("@p1",textBoxAd.Text);
            Komut.Parameters.AddWithValue("@p2",textBoxSYD.Text);
            Komut.Parameters.AddWithValue("@p3",maskedTextBox1.Text);
            Komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(textBoxMAAS.Text));
            Komut.Parameters.Add("@p5", textBoxResim.Text);
            Komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi başarılı şekilde gerçekleştirilmiştir.", "Bilgi",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGERİ_Click(object sender, EventArgs e)
        {
            Görevliler frm = new Görevliler();
            frm.Show();
            this.Hide();
        }

        private void buttonCks_Click(object sender, EventArgs e)
        {
            DialogResult secim1 = new DialogResult();
            secim1 = MessageBox.Show("Programdan çıkılsın mı?", "Uyarı",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim1 == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
       
        private void buttonResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpeg Dosyaları (*.jpeg)|*.jpeg|Jpg Dosyaları (*.jpg)|*.jpg|Png Dosyaları (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosyanın ismi
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
               textBoxResim.Text = openFileDialog1.FileName;
            }

        }

        private void EKLEFRM_Load(object sender, EventArgs e)
        {
            textBoxResim.Visible = false;
        }
    }
}
