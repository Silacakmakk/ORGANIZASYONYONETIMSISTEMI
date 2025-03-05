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

namespace organizasyon_planlama_sistemi
{
    public partial class Paket_Sil : Form
    {
        public Paket_Sil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection("Data Source=SLA\\SQLEXPRESS;Initial Catalog=DdOrganizasyon_Planlama_Sistemi;Integrated Security=True");
        private void Paket_Sil_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select * From organizasyon ", baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);//datatable ı doldurduk

            //datatable deki degerleri comboboxa atamış olduk
            comboBoxKtgr.DisplayMember = "org_adi";
            comboBoxKtgr.ValueMember = "org_id";
            comboBoxKtgr.DataSource = dt1;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int KtgrSecım = int.Parse(comboBoxKtgr.SelectedValue.ToString());
            switch (KtgrSecım)
            {
                case 1:
                    DialogResult secim = new DialogResult();
                    secim = MessageBox.Show(textBox1.Text + ". Dugun Paketini silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (secim == DialogResult.Yes)
                    {
                        baglanti.Open();
                        //ekleme,silme ve güncelleme işlemlerinde her seferde açma ve kapama yapmak zorundayız
                        SqlCommand komut = new SqlCommand("Delete From dugun_table where dugun_id=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1",textBox1.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show(textBox1.Text + ". Dugun Paketi silindi", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi gerçekleştirilmedi.", "Uyarı",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 2:
                    DialogResult secim2 = new DialogResult();
                    secim2 = MessageBox.Show(textBox1.Text + ". Kına Paketini silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (secim2 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        //ekleme,silme ve güncelleme işlemlerinde her seferde açma ve kapama yapmak zorundayız
                        SqlCommand komut = new SqlCommand("Delete From kina_table where kina_id=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", textBox1.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show(textBox1.Text + ". Kına Paketi silindi", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi gerçekleştirilmedi.", "Uyarı",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 3:
                    DialogResult secim3 = new DialogResult();
                    secim3 = MessageBox.Show(textBox1.Text + ". Nişan Paketini silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (secim3 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        //ekleme,silme ve güncelleme işlemlerinde her seferde açma ve kapama yapmak zorundayız
                        SqlCommand komut = new SqlCommand("Delete From nisan_table where nisan_id=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", textBox1.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show(textBox1.Text + ". Nisan Paketi silindi", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi gerçekleştirilmedi.", "Uyarı",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 4:
                    DialogResult secim4 = new DialogResult();
                    secim4 = MessageBox.Show(textBox1.Text + ". Bekarlığa Veda Paketini silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (secim4 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        //ekleme,silme ve güncelleme işlemlerinde her seferde açma ve kapama yapmak zorundayız
                        SqlCommand komut = new SqlCommand("Delete From bekarligaVeda_table where bkrVeda_id=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", textBox1.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show(textBox1.Text + ". Bekarlığa Veda Paketi silindi", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi gerçekleştirilmedi.", "Uyarı",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
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
