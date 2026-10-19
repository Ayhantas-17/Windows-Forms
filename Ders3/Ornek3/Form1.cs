using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHarfNotu.Visible = false;
            lblOrtalama.Visible = false;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(txbVize.Text);
            double final = Convert.ToDouble(txbFinal.Text);
            double ort = vize * 0.4 + final * 0.6;

            lblOrtalama.Visible = true;
            lblOrtalama.Text = ort.ToString();

            string HarfNotu;
            if (ort <= 50)
            {
                HarfNotu = "DD";
            }
            else if (ort > 50 && ort <= 60)
            {
                HarfNotu = "CC";
            }
            else if (ort > 60 && ort <= 80)
            {
                HarfNotu = "BB";
            }
            else { HarfNotu = "AA"; }

            lblHarfNotu.Visible = true;
            lblHarfNotu.Text = HarfNotu;
            
        }

        private void txbVize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbFinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
