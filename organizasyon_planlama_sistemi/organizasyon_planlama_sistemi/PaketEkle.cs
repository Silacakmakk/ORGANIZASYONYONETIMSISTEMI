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
    public partial class PaketEkle : Form
    {
        
        public PaketEkle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True;");
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (int.Parse(comboBoxKtgr.SelectedValue.ToString()) == 1)
            {
                conn.Open();
                SqlCommand dugun = new SqlCommand("INSERT INTO dugun_table (dpaket_adi,dpaket_içerigi,dfiyat,org_id) values (@p1,@p2,@p3,@p4)", conn);
                dugun.Parameters.AddWithValue("@p1", textBoxAd.Text);
                dugun.Parameters.AddWithValue("@p2", richTextBox1.Text);
                dugun.Parameters.AddWithValue("@p3", textBox1.Text);
                dugun.Parameters.AddWithValue("@p4", int.Parse(comboBoxKtgr.SelectedValue.ToString()));
                dugun.ExecuteNonQuery();
                conn.Close();

            }
            else if (int.Parse(comboBoxKtgr.SelectedValue.ToString()) == 2)
            {
                conn.Open();
                SqlCommand kina = new SqlCommand("INSERT INTO kina_table (kpaket_adi,kpaket_icerigi,kfiyat,org_id) Values (@p1),@p2,@p3,@p4)", conn);
                kina.Parameters.AddWithValue("@p1", textBoxAd.Text);
                kina.Parameters.AddWithValue("@p2", richTextBox1.Text);
                kina.Parameters.AddWithValue("@p3", textBox1.Text);
                kina.Parameters.AddWithValue("@p4", int.Parse(comboBoxKtgr.SelectedValue.ToString()));
                kina.ExecuteNonQuery();
                conn.Close();
            }
            else if (int.Parse(comboBoxKtgr.SelectedValue.ToString()) == 3)
            {
                conn.Open();
                SqlCommand nisan = new SqlCommand("INSERT INTO nisan_table (npaket_adi,npaket_icerigi,nfiyat,org_id) Values (@p1),@p2,@p3,@p4)", conn);
                nisan.Parameters.AddWithValue("@p1", textBoxAd.Text);
                nisan.Parameters.AddWithValue("@p2", richTextBox1.Text);
                nisan.Parameters.AddWithValue("@p3", textBox1.Text);
                nisan.Parameters.AddWithValue("@p4", int.Parse(comboBoxKtgr.SelectedValue.ToString()));
                nisan.ExecuteNonQuery();
                conn.Close();
            }
            else 
            { 
                conn.Open();
                SqlCommand bkrveda = new SqlCommand("INSERT INTO bekarligaVeda_table (bkrVedapaket_adi,bkrVedapaket_icerigi,bkrVedafiyat,org_id) Values (@p1,@p2,@p3,@p4)", conn);
                bkrveda.Parameters.AddWithValue("@p1", textBoxAd.Text);
                bkrveda.Parameters.AddWithValue("@p2", richTextBox1.Text);
                bkrveda.Parameters.AddWithValue("@p3", textBox1.Text);
                bkrveda.Parameters.AddWithValue("@p4", int.Parse(comboBoxKtgr.SelectedValue.ToString()));
                bkrveda.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Paket kaydı başarılı şekilde gerçekleştirilmiştir.", "Bilgi",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void PaketEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select * From organizasyon ", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);//datatable ı doldurduk

            //datatable deki degerleri comboboxa atamış olduk
            comboBoxKtgr.DisplayMember = "org_adi";
            comboBoxKtgr.ValueMember = "org_id";
            comboBoxKtgr.DataSource = dt1;
        }

        private void buttonPaket_Click(object sender, EventArgs e)
        {
            Paketler frm = new Paketler();
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
    }
}
