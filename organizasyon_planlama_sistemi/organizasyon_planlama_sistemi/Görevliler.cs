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
    public partial class Görevliler : Form
    {
        public Görevliler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");

        private void buttonSIL_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show(textBoxID.Text + ". Personeli silmek istediğinize emin misiniz?", "Uyarı",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes)
            {
                baglanti.Open();

                // Önce gorev_alir tablosundaki ilişkili görevleri sil
                SqlCommand silGorevler = new SqlCommand("DELETE FROM gorev_alir WHERE clsn_id=@p1", baglanti);
                silGorevler.Parameters.AddWithValue("@p1", textBoxID.Text);
                silGorevler.ExecuteNonQuery();

                // Daha sonra calisan_table'daki çalışanın kaydını sil
                SqlCommand silCalisan = new SqlCommand("DELETE FROM calisan_table WHERE clsn_id=@p1", baglanti);
                silCalisan.Parameters.AddWithValue("@p1", textBoxID.Text);
                silCalisan.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Çalışan ve ilişkili tüm kayıtlar silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            else
            {
                MessageBox.Show("Silme işlemi gerçekleştirilmedi.", "Uyarı",
         MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void buttonListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT clsn_id AS ID, clsn_AD AS ADI,clsn_SOYAD AS SOYAD, clsn_TEL AS TEL,clsn_maas AS maas,Resim FROM calisan_table", baglanti);
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
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //dataGridview de herhangi bir hücreye tıklama gerçekleştiğinde yapılacak işlemler için kullanılan event
            textBoxID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            //e=tıklanmış olan satırın ındexini al id=0.sütün stringe çevir comboboxa ata
            textBoxAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxMAAS.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxResim.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            pictureBox1.ImageLocation= dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("update calisan_table set clsn_AD=@p1,clsn_SOYAD=@p2,clsn_TEL= @p3,clsn_maas=@p4,Resim=@p5 where clsn_id=@p6", baglanti);
            komut3.Parameters.AddWithValue("@p6", Convert.ToInt32(textBoxID.Text));
            komut3.Parameters.AddWithValue("@p1", textBoxAD.Text);
            komut3.Parameters.AddWithValue("@p2", textBoxSOYAD.Text);
            komut3.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut3.Parameters.AddWithValue("@p4",textBoxMAAS.Text);
            komut3.Parameters.AddWithValue("@p5",textBoxResim.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgileri Başarılı Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void buttonEKLE_Click(object sender, EventArgs e)
        {
            EKLEFRM frm1 = new EKLEFRM();
            frm1.Show();
            this.Hide();
           
        }

        private void Görevliler_Load(object sender, EventArgs e)
        {
            textBoxResim.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void buttonGörevYeri_Click(object sender, EventArgs e)
        {
            OrganizasyonRol frm= new OrganizasyonRol();
            frm.Show();
            this.Hide();
        }
    }
}
