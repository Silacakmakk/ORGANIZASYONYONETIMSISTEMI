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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//UNUTMa bak bir sipariş olustururken var olan paketler degişmez ancak yeni müşteri degişebilir o yuzden musteri normal ancak digerleri var olan
namespace organizasyon_planlama_sistemi
{
    public partial class Siparişler : Form
    {
        public Siparişler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");
        private void Siparişler_Load(object sender, EventArgs e)
        {
            textBoxID.Visible = false;
            
           // ŞİMdi paket adları
            SqlCommand komut2 = new SqlCommand("Select * From paketler ", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2= new DataTable();
            da2.Fill(dt2);//datatable ı doldurduk

            //datatable deki degerleri comboboxa atamış olduk
            comboBoxPAKET.DisplayMember = "paket_adi";
            comboBoxPAKET.ValueMember = "paket_id";
            comboBoxPAKET.DataSource = dt2;

            //Şimdi ürün adları
            SqlCommand komut3 = new SqlCommand("Select * From  paket_disi_urun ", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);//datatable ı doldurduk

            //datatable deki degerleri comboboxa atamış olduk
            comboBoxURUNAD.DisplayMember = "urun_ADI";
            comboBoxURUNAD.ValueMember = "urun_id";
            comboBoxURUNAD.DataSource = dt3;

            YenileDataGridView();

        }
        private void YenileDataGridView()
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft sans Serif", 9);
            string query = @" SELECT musteri_table.mstr_id, musteri_table.mstr_AD AS ADI
                     ,musteri_table.mstr_SOYAD AS SOYAD,musteri_table.mstr_TEL AS TELEFON
                    ,musteri_table.adres AS ADRES
                    ,paket_satinAL.saat AS Saat
                    ,paket_satinAL.tarih AS Tarih
                    ,paketler.paket_adi AS PaketAdi
                    ,paket_disi_urun.urun_ADI AS UrunADI
                    ,urun_satinAL.adet AS Adet
                FROM 
                    paket_satinAL
                LEFT JOIN
                    urun_satinAL ON paket_satinAL.mstr_id = urun_satinAL.mstr_id
                LEFT JOIN
                    paket_disi_urun ON urun_satinAL.urun_id = paket_disi_urun.urun_id
                LEFT JOIN 
                    paketler ON paket_satinAL.paket_id = paketler.paket_id
                LEFT JOIN
                    musteri_table ON paket_satinAL.mstr_id = musteri_table.mstr_id;";

            SqlCommand komut = new SqlCommand(query, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // 'mstr_id' sütununu gizle
            dataGridView1.Columns["mstr_id"].Visible = false;

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

        private void buttonAnaMnu_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void buttonUrun_Click(object sender, EventArgs e)
        {
            Urunler  frm1 = new Urunler();
            frm1.Show();
            this.Hide();
        }

        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            Musterilercs frm2 = new Musterilercs();
            frm2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //dataGridview de herhangi bir hücreye tıklama gerçekleştiğinde yapılacak işlemler için kullanılan event
            textBoxMusterıAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //e=tıklanmış olan satırın ındexini al id=0.sütün stringe çevir 
            MusterıSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            maskedTextBoxSAAT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            maskedTextBoxTARIH.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBoxPAKET.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBoxURUNAD.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = @"UPDATE paket_satinAL SET 
                    saat = @yeniSaat,
                    tarih = @yeniTarih
            FROM 
                    paket_satinAL
            LEFT JOIN
                    urun_satinAL ON paket_satinAL.mstr_id = urun_satinAL.mstr_id
            LEFT JOIN
                    paket_disi_urun ON urun_satinAL.urun_id = paket_disi_urun.urun_id
            LEFT JOIN 
                    paketler ON paket_satinAL.paket_id = paketler.paket_id
            LEFT JOIN 
                    organizasyon ON paketler.org_id = organizasyon.org_id
            LEFT JOIN
                    musteri_table ON paket_satinAL.mstr_id = musteri_table.mstr_id
            WHERE 
                    paket_satinAL.mstr_id = @musteriID;";

            SqlCommand command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@yeniSaat", Convert.ToDateTime(maskedTextBoxSAAT.Text)); 
            command.Parameters.AddWithValue("@yeniTarih", Convert.ToDateTime(maskedTextBoxTARIH.Text));
            command.Parameters.AddWithValue("@musteriID", Convert.ToInt32(textBoxID.Text));
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler güncellendi.","Bilgi",
                MessageBoxButtons.OK,MessageBoxIcon.Information);

            YenileDataGridView();

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Müşteri bilgileri ekleme
            string query1 = @"INSERT INTO musteri_table (mstr_AD, mstr_SOYAD, mstr_TEL, adres)
                  VALUES (@Adi, @Soyad, @Telefon, @Adres);
                  SELECT SCOPE_IDENTITY();";  // Eklenen müşterinin ID'sini döndürüyoruz
            SqlCommand KOMUT1 = new SqlCommand(query1, baglanti);

            // Parametreler ekleniyor
            KOMUT1.Parameters.AddWithValue("@Adi", textBoxMusterıAD.Text);
            KOMUT1.Parameters.AddWithValue("@Soyad", MusterıSoyad.Text);
            KOMUT1.Parameters.AddWithValue("@Telefon", maskedTextBox1.Text);
            KOMUT1.Parameters.AddWithValue("@Adres", richTextBox1.Text);

            // Müşteri ekleniyor ve müşteri ID'si alınıyor
            int musteriID = Convert.ToInt32(KOMUT1.ExecuteScalar());  // SCOPE_IDENTITY() ile müşteri ID'sini alıyoruz

            // Paket satın alma işlemi
            string query2 = @"INSERT INTO paket_satinAL (mstr_id, paket_id, saat, tarih)
                  VALUES (@MusteriID, @PaketID, @Saat, @Tarih);";
            SqlCommand KOMUT2 = new SqlCommand(query2, baglanti);

            // Parametreler ekleniyor
            KOMUT2.Parameters.AddWithValue("@MusteriID", musteriID);  // Müşteri ID'si burada kullanılıyor
            KOMUT2.Parameters.AddWithValue("@PaketID", comboBoxPAKET.SelectedValue);
            KOMUT2.Parameters.AddWithValue("@Saat", Convert.ToDateTime(maskedTextBoxSAAT.Text));
            KOMUT2.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(maskedTextBoxTARIH.Text));

            // Paket satın alma işlemi yapılıyor
            KOMUT2.ExecuteNonQuery();

            // Ürün satın alma işlemi
            string query3 = @"INSERT INTO urun_satinAL (mstr_id, urun_id, adet)
                  VALUES (@MusteriID, @UrunID, @Adet);";
            SqlCommand KOMUT3 = new SqlCommand(query3, baglanti);

            // Parametreler ekleniyor
            KOMUT3.Parameters.AddWithValue("@MusteriID", musteriID);  // Müşteri ID'si burada da kullanılıyor
            KOMUT3.Parameters.AddWithValue("@UrunID", comboBoxURUNAD.SelectedValue);
            KOMUT3.Parameters.AddWithValue("@Adet", Convert.ToInt32(numericUpDown1.Value));

            // Ürün satın alma işlemi yapılıyor
            KOMUT3.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Sipariş eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileDataGridView();
           


        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxMusterıAD.Text = " ";
            textBoxID.Text = " ";
            MusterıSoyad.Text = "";
            numericUpDown1.Value = 0;
            maskedTextBox1.Text = "";
            richTextBox1.Text = " ";
            maskedTextBoxSAAT.Text = "";
            maskedTextBoxTARIH.Text = " ";
            comboBoxPAKET.Text = "";
            comboBoxURUNAD.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Önce urun_satinAL tablosundaki ilişkili kayıtları sil
            SqlCommand silUrunler = new SqlCommand("DELETE FROM urun_satinAL WHERE mstr_id=@p1", baglanti);
            silUrunler.Parameters.AddWithValue("@p1", textBoxID.Text);
            silUrunler.ExecuteNonQuery();

            // Daha sonra paket_satinAL tablosundaki siparişleri sil
            SqlCommand silSiparisler = new SqlCommand("DELETE FROM paket_satinAL WHERE mstr_id=@p1", baglanti);
            silSiparisler.Parameters.AddWithValue("@p1",textBoxID.Text);
            silSiparisler.ExecuteNonQuery();

            // Son olarak müşteri kaydını sil
            SqlCommand silMusteri = new SqlCommand("DELETE FROM musteri_table WHERE mstr_id=@p1", baglanti);
            silMusteri.Parameters.AddWithValue("@p1", textBoxID.Text);
            silMusteri.ExecuteNonQuery();

            
            baglanti.Close();

            MessageBox.Show("Müşteri ve ilişkili tüm kayıtlar silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileDataGridView();
        }
    }
}
