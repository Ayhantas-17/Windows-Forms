using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblYazdir.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            lblYazdir.Visible = true;
            lbYazdir.Items.Add(txbAd.Text+" "+txbSoyad.Text+" Cep No: "+mTxbCepNo.Text);
            lblYazdir.Text = txbOgrNo.Text + " numaralı " + txbAd.Text + " " + txbSoyad.Text + " " + cbxBolum.Text + " bölümünde okuyor.";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cbxBolum.Items.Add(txbBolumEkle.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbYazdir.Items.Clear();
        }
    }
}
