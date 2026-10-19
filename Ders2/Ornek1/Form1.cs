using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(tbSayi1.Text);
            int s2 = Convert.ToInt32(tbSayi2.Text);
            int s3 = s1 + s2;
            lblSonuc.Visible = true;
            lblSonuc.Text = "Toplam= "+s3.ToString();

        }

        private void tbSayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSayi2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
