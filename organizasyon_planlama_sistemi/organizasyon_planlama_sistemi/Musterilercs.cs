using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace organizasyon_planlama_sistemi
{
    public partial class Musterilercs : Form
    {
        public Musterilercs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnaMnu_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
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
                Application.Exit();
            }
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM musteri_table", baglanti);
            // veri tabanımızın içinde sgl sorgumuzu çalıştırdık
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //koprumuzu olusturduk
            DataTable dt = new DataTable();
            // veri tablosu sınıfından nesne ürettim
            da.Fill(dt); // tablomu kopruden gelen degerler ile doldurucam
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridview de herhangi bir hücreye tıklama gerçekleştiğinde yapılacak işlemler için kullanılan event
            textBoxMusterıID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e=tıklanmış olan satırın ındexini al id=0.sütün stringe çevir comboboxa ata
            textBoxMusterıAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            MusterıSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("update musteri_table set mstr_AD=@p1,mstr_SOYAD=@p2,mstr_TEL= @p3,adres=@p4 where mstr_id=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p5", Convert.ToInt32(textBoxMusterıID.Text));
            komut3.Parameters.AddWithValue("@p1", textBoxMusterıAD.Text);
            komut3.Parameters.AddWithValue("@p2", MusterıSoyad.Text);
            komut3.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut3.Parameters.AddWithValue("@p4", richTextBox1.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Başarılı Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }


        private void buttonSipariş_Click(object sender, EventArgs e)
        {
            Siparişler frm = new Siparişler();
            frm.Show();
            this.Hide();
        }
    }
}
