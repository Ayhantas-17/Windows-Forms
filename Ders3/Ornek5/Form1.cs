using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int id = 0;
            string metinIlave="İlave ürün ";
            if (cbKasar.Checked)
            {
                metinIlave = metinIlave +" "+ cbKasar.Text;
                id = 1;
            }
             if (cbSucuk.Checked)
            {
                metinIlave=metinIlave+" "+ cbSucuk.Text;
                id = 1;
            }
             if (cbKenar.Checked)
            {
                metinIlave = metinIlave +" "+ cbKenar.Text;
                id = 1;
            }
             if (cbMantar.Checked)
            {
                metinIlave = metinIlave +" "+ cbMantar.Text;
                id = 1;
            }
            if (id==0)
            {
                metinIlave = metinIlave + "yok";
            }
            string metin = txbAd.Text + " " + txbsoyad.Text + " " + cbxPizza.Text + " sipaiş etti " + metinIlave;
            listBox1.Items.Add(metin);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
