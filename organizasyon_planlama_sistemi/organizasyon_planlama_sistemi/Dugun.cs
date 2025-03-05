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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace organizasyon_planlama_sistemi
{
    public partial class Dugun : Form
    {
        public Dugun()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");
        

        private void buttonListele_Click(object sender, EventArgs e)
        {
            string query = "SELECT dugun_id AS ID,dpaket_adi AS PaketAdı,dpaket_içerigi AS Icerık,dfiyat AS Fiyat, dugun_table.org_id " +
                "FROM dugun_table INNER JOIN organizasyon ON dugun_table.org_id = organizasyon.org_id";
            SqlCommand komut = new SqlCommand(query, baglanti);
            // veri tabanımızın içinde sgl sorgumuzu çalıştırdık
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //koprumuzu olusturduk
            DataTable dt = new DataTable();
            // veri tablosu sınıfından nesne ürettim
            da.Fill(dt); // tablomu kopruden gelen degerler ile doldurucam
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["org_id"].Visible = false;
            
        }

        private void Dugun_Load(object sender, EventArgs e)
        {
            // Sadece org_id'si 1 olan kayıtları almak için sorgu
            SqlCommand komut1 = new SqlCommand("SELECT * FROM organizasyon WHERE org_id = @orgId", baglanti);
            komut1.Parameters.AddWithValue("@orgId", 1); // @orgId parametresine 1 değerini atıyoruz.

            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1); // DataTable'ı dolduruyoruz.

            textBox1.Text = dt1.Rows[0]["org_adi"].ToString();

        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("update dugun_table set dpaket_adi=@p1,dpaket_içerigi=@p2,dfiyat= @p3 where dugun_id=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p5", Convert.ToInt32(textBoxID.Text));
            komut3.Parameters.AddWithValue("@p1",textBoxAD.Text);
            komut3.Parameters.AddWithValue("@p2",richTextBox1.Text);
            komut3.Parameters.AddWithValue("@p3",textBox1Fyt.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paket Bilgileri Başarılı Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridview de herhangi bir hücreye tıklama gerçekleştiğinde yapılacak işlemler için kullanılan event
            textBoxID.Text= dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e=tıklanmış olan satırın ındexini al id=0.sütün stringe çevir comboboxa ata
            textBoxAD.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
             richTextBox1.Text= dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1Fyt.Text  = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
           

        }

        private void buttonCks_Click_1(object sender, EventArgs e)
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
            PaketEkle frm1 = new PaketEkle();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paket_Sil frm2 = new Paket_Sil();
            frm2.Show();
            this.Hide();
        }
    }
}
