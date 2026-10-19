using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin1 = tbAd.Text + " " + tbSoyad.Text + " " + cbxDogumYeri.Text+" ilinde doğdu.";
            string metin2 = " Cep No: " + mtxbCep.Text + " Adres=" + rtxbAdres.Text;
            listBox1.Items.Add(metin1 + metin2);
          
        }
    }
}
