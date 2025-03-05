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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = SLA\\SQLEXPRESS; Initial Catalog = DdOrganizasyon_Planlama_Sistemi; Integrated Security = True");
       

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
        private void YenileDataGridView()
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft sans Serif", 9);
            SqlCommand komut = new SqlCommand("Select * From paket_disi_urun", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }


        private void Urunler_Load(object sender, EventArgs e)
        {
            YenileDataGridView();
        }

        private void buttonAnaMnu_Click(object sender, EventArgs e)
        {
           Siparişler frm = new Siparişler();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridview de herhangi bir hücreye tıklama gerçekleştiğinde yapılacak işlemler için kullanılan event
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e=tıklanmış olan satırın ındexini al id=0.sütün stringe çevir 
            textBoxAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show(textBoxID.Text + ". Ürünü silmek istediğinize emin misiniz?", "Uyarı",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes)
            {
                baglanti.Open();
                //ekleme,silme ve güncelleme işlemlerinde her seferde açma ve kapama yapmak zorundayız
                SqlCommand komut = new SqlCommand("Delete From paket_disi_urun where urun_id=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", textBoxID.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(textBoxID.Text + ". Ürün silindi", "Uyarı",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                YenileDataGridView();
            }
            else
            {
                MessageBox.Show("Silme işlemi gerçekleştirilmedi.", "Uyarı",
         MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonEkle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("INSERT INTO paket_disi_urun (urun_ADI,urun_fiyati,stok) values (@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxAD.Text);
            komut1.Parameters.AddWithValue("@p2", Convert.ToSingle(textBoxFiyat.Text));
            komut1.Parameters.AddWithValue("@p3", Convert.ToInt32(numericUpDown1.Value));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işleminiz başarılı bir şekilde gerçekleşmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileDataGridView();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("UPDATE paket_disi_urun SET urun_ADI=@p1, urun_fiyati=@p2, stok=@p3 WHERE urun_id=@p4", baglanti);
            komut2.Parameters.AddWithValue("@p1", textBoxAD.Text);
            komut2.Parameters.AddWithValue("@p2", Convert.ToSingle(textBoxFiyat.Text));
            komut2.Parameters.AddWithValue("@p3", Convert.ToInt32(numericUpDown1.Value));
            komut2.Parameters.AddWithValue("@p4", Convert.ToInt32(textBoxID.Text)); // eksik parametre ekleniyor
            komut2.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Güncelleme işleminiz başarılı bir şekilde gerçekleşmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileDataGridView();

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxAD.Text = " ";
            textBoxID.Text = " ";
            textBoxFiyat.Text = "";
            numericUpDown1.Value = 0;
        }
    }
}
