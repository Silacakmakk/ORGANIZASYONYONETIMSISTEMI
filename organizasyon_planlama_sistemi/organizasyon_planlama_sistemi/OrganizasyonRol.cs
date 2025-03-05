using System;
using System.Collections;
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
    public partial class OrganizasyonRol : Form
    {
        public OrganizasyonRol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");
        private void OrganizasyonRol_Load(object sender, EventArgs e)
        {
            textBoxCLSNID.Visible = false;
            // ŞİMdi paket adları
            SqlCommand komut2 = new SqlCommand("Select * From paketler ", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);//datatable ı doldurduk

            //datatable deki degerleri comboboxa atamış olduk
            comboBoxPAKET.DisplayMember = "paket_adi";
            comboBoxPAKET.ValueMember = "paket_id";
            comboBoxPAKET.DataSource = dt2;
            YenileDataGridView();
        }
        private void YenileDataGridView()
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft sans Serif", 9);
            string query = @" SELECT calisan_table.clsn_id, calisan_table.clsn_AD AS ADI
                     ,calisan_table.clsn_SOYAD AS SOYAD,calisan_table.clsn_TEL AS TELEFON
                    ,calisan_table.clsn_maas AS maas
                    ,gorev_alir.gorev_id AS GörevID
                    ,gorev_alir.gorev_tanimi AS Görevi
                    ,paketler.paket_adi AS PaketAdi
                FROM 
                    gorev_alir
                LEFT JOIN 
                    paketler ON gorev_alir.paket_id = paketler.paket_id
                LEFT JOIN
                    calisan_table ON gorev_alir.clsn_id=calisan_table.clsn_id;";

            SqlCommand komut = new SqlCommand(query, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // 'clsn_id' sütununu gizle
            dataGridView1.Columns["clsn_id"].Visible = false;
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //dataGridview de herhangi bir hücreye tıklama gerçekleştiğinde yapılacak işlemler için kullanılan event
            textBoxCLSNID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            //e=tıklanmış olan satırın ındexini al id=0.sütün stringe çevir comboboxa ata
            textBoxAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            GorevliSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxMAAS.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxID.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            richTextBox2.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            comboBoxPAKET.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Görevliler frm = new Görevliler();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = @"UPDATE gorev_alir
            SET 
            paket_id = @yenipaket,
            gorev_tanimi = @yenigorev
            FROM 
            gorev_alir
            LEFT JOIN 
            paketler ON gorev_alir.paket_id = paketler.paket_id
                LEFT JOIN
            calisan_table ON gorev_alir.clsn_id = calisan_table.clsn_id
            WHERE 
            gorev_alir.clsn_id = @calisanID;";

            SqlCommand command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@yenipaket", int.Parse(comboBoxPAKET.SelectedValue.ToString()));
            command.Parameters.AddWithValue("@yenigorev", richTextBox2.Text);
            command.Parameters.AddWithValue("@calisanID", Convert.ToInt32(textBoxID.Text));
            command.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Bilgiler güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            YenileDataGridView();


        }
    }
}
