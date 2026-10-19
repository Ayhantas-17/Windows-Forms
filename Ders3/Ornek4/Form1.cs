using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHesapla.Visible = false;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblHesapla.Visible = true;
            double sayi1, sayi2;
            sayi1 = Convert.ToDouble(txbSayi1.Text);
            sayi2 = Convert.ToDouble(txbSayi2.Text);
            
            if (rbtnToplama.Checked)
            {
                lblHesapla.Text = (sayi1 + sayi2).ToString();
            }
            else if (rbtnCikarma.Checked)
            {
                lblHesapla.Text = (sayi1 - sayi2).ToString();
            }
            else if (rbtnCarpim.Checked)
            {
                lblHesapla.Text = (sayi1 * sayi2).ToString();
            }
            else if (rbtnBolme.Checked)
            {
                lblHesapla.Text = (sayi1 / sayi2).ToString();
            }
        }
    }
}
