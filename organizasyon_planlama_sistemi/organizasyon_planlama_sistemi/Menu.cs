using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organizasyon_planlama_sistemi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_pkt_Click(object sender, EventArgs e)
        {
            Paketler frm = new Paketler();
            frm.Show();
            this.Hide();
        }

        private void button_grv_Click(object sender, EventArgs e)
        {
            Görevliler frm1 = new Görevliler();
            frm1.Show();
            this.Hide();
        }

        private void button_mstr_Click(object sender, EventArgs e)
        {
            Musterilercs frm2 = new Musterilercs();
            frm2.Show();
            this.Hide();
        }

        private void button_urun_Click(object sender, EventArgs e)
        {
           Siparişler frm3 = new Siparişler();
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
                Application.Exit();
            }

        }
    }
}
