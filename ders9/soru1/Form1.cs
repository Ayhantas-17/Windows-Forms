using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        adsoyad kişi1;
        private void button1_Click(object sender, EventArgs e)
        {
            kişi1 = new adsoyad();
            kişi1.ad = textBox1.Text;
            kişi1.soyad = textBox2.Text;
            kişi1.vize =Convert.ToInt16(textBox3.Text);
            kişi1.final =Convert.ToInt16(textBox4.Text);

            MessageBox.Show("kişi oluşturuldu");



            //adsoyad kişi2;
            //kişi2 = new adsoyad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(kişi1.metinOlustur());
            label5.Text = Convert.ToString(kişi1.ort);
          
            listBox1.Items.Add(kişi1.ort2);
            kişi1.ort2 = 70;
        }
    }
}
