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
    public partial class Paketler : Form
    {
        public Paketler()
        {
            InitializeComponent();
        }

        private void buttonKina_Click(object sender, EventArgs e)
        {
            Kina frm2 = new Kina();
            frm2.Show();
            this.Hide();
        }

        private void buttonAnaMnu_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
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
                Application.Exit();
            }

        }

        private void buttonDgn_Click(object sender, EventArgs e)
        {
            Dugun frm1 = new Dugun();
            frm1.Show();
            this.Hide();
        }

        private void buttonNisan_Click(object sender, EventArgs e)
        {
            nisan frm3 = new nisan();
            frm3.Show();
            this.Hide();
        }

        private void buttonbklgVeda_Click(object sender, EventArgs e)
        {
            bkrl_veda frm4 = new bkrl_veda();
            frm4.Show();
            this.Hide();
        }
    }
}
