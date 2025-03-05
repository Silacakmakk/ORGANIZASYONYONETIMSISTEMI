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
    public partial class bkrl_veda : Form
    {
        public bkrl_veda()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");
        private void bkrl_veda_Load(object sender, EventArgs e)
        {
            // Sadece org_id'si 4 olan kayıtları almak için sorgu
            SqlCommand komut1 = new SqlCommand("SELECT * FROM organizasyon WHERE org_id = @orgId", baglanti);
            komut1.Parameters.AddWithValue("@orgId", 4); // @orgId parametresine 3 değerini atıyoruz.

            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1); // DataTable'ı dolduruyoruz.

            textBox1.Text = dt1.Rows[0]["org_adi"].ToString();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            string query = "SELECT bkrVeda_id AS ID, bkrVedapaket_adi AS PaketAdi, bkrVedapaket_icerigi AS Icerik, " +
               "bkrVedafiyat AS Fiyat, bekarligaVeda_table.org_id " +
               "FROM bekarligaVeda_table INNER JOIN organizasyon ON bekarligaVeda_table.org_id = organizasyon.org_id";

            SqlCommand Komut = new SqlCommand(query, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            //koprumuzu olusturduk
            DataTable dt = new DataTable();
            // veri tablosu sınıfından nesne ürettim
            da.Fill(dt); // tablomu kopruden gelen degerler ile doldurucam
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["org_id"].Visible = false;
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridview de herhangi bir hücreye tıklama gerçekleştiğinde yapılacak işlemler için kullanılan event
            textBoxID.Text = dataGridView2.Rows [e.RowIndex].Cells[0].Value.ToString();
            //e=tıklanmış olan satırın ındexini al id=0.sütün stringe çevir comboboxa ata
            textBoxAD.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1Fyt.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            PaketEkle frm = new PaketEkle();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paket_Sil frm2= new Paket_Sil();
            frm2.Show();
            this.Hide();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update bekarligaVeda_table set bkrVedapaket_adi=@p1,bkrVedapaket_icerigi=@p2,bkrVedafiyat= @p3 where bkrVeda_id=@p5", baglanti);
            komut1.Parameters.AddWithValue("@p5", Convert.ToInt32(textBoxID.Text));
            komut1.Parameters.AddWithValue("@p1", textBoxAD.Text);
            komut1.Parameters.AddWithValue("@p2", richTextBox1.Text);
            komut1.Parameters.AddWithValue("@p3", textBox1Fyt.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paket Bilgileri Başarılı Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void buttonAnaMnu_Click(object sender, EventArgs e)
        {
            Paketler frm3=new Paketler();
            frm3.Show();
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
    }
}
