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

namespace organizasyon_planlama_sistemi
{
    public partial class Kina : Form
    {
        public Kina()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");

        private void Kina_Load(object sender, EventArgs e)
        {

            // Sadece org_id'si 2 olan kayıtları almak için sorgu
            SqlCommand komut1 = new SqlCommand("SELECT * FROM organizasyon WHERE org_id = @orgId", baglanti);
            komut1.Parameters.AddWithValue("@orgId", 2); // @orgId parametresine 2 değerini atıyoruz.

            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1); // DataTable'ı dolduruyoruz.

            textBox1.Text = dt1.Rows[0]["org_adi"].ToString();


        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            string query = "Select kina_id AS ID,kpaket_adi AS PaketADI,kpaket_icerigi AS Icerık,kfiyat AS " +
                "Fiyat,kina_table.org_id From kina_table INNER JOIN organizasyon ON kina_table.org_id=organizasyon.org_id";
            SqlCommand komut2 = new SqlCommand(query,baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            dataGridView1.Columns["org_id"].Visible = false;
           


        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            //ekleme,silme güncelleme yaparken baglantıyı açıp tekrardan kapatman gerek sakın unutma
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("UPDATE kina_table SET kpaket_adi=@p1, kpaket_icerigi=@p2,kfiyat=@p3 where kina_id=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p1",textBoxAD.Text);
            komut3.Parameters.AddWithValue("@p2",richTextBox1.Text);
            komut3.Parameters.AddWithValue("@p3",textBox1Fyt.Text);
            komut3.Parameters.AddWithValue("@p5", Convert.ToInt32(textBoxID.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paket bilgileri başarılı şekilde güncellenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridview de herhangi bir hücreye tıklama gerçekleştiğinde yapılacak işlemler için kullanılan event
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e=tıklanmış olan satırın ındexini al id=0.sütün stringe çevir comboboxa ata
            textBoxAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1Fyt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
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

        private void buttonAnaMnu_Click(object sender, EventArgs e)
        {

            Paketler frm = new Paketler();
            frm.Show();
            this.Hide();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            PaketEkle frm2 = new PaketEkle();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paket_Sil frm3 = new Paket_Sil();
            frm3.Show();
            this.Hide();
        }
    }
}
