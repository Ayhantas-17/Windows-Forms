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
    public partial class Matematik : Form
    {
        public Matematik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            string metin = $"Sayı 1'in mutlak değeri = {Math.Abs(sayi)}";
            MessageBox.Show(metin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decimal sayi = Convert.ToDecimal(textBox1.Text);
            string metin = $"Sayı 1'in Alta Yuvarlanmış Değeri = {Math.Floor(sayi)}";
            MessageBox.Show(metin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal sayi = Convert.ToDecimal(textBox1.Text);
            string metin = $"Sayı 1'in Üste Yuvarlanmış Değeri = {Math.Ceiling(sayi)}";
            MessageBox.Show(metin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox1.Text);
            int s2 = Convert.ToInt16(textBox2.Text);
            Random rnd =new Random();
            string metin = $"Sayı 1 ile Sayı 2 arasında keyfi sayı = {rnd.Next(s1,s2+1)}";
            MessageBox.Show(metin);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            string metin = $"Sayı 1'in sinüs Değeri = {Math.Sin(Math.PI*sayi/180)}";
            MessageBox.Show(metin);
            // sin ve cos fonksiyonları radyan türden veri alır. R=pi*Derece/180
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox2.Text);
            double aci = Math.PI * sayi / 180;
            string metin = $"Sayı 2'in cosinüs Değeri = {Math.Cos(aci)}";
            MessageBox.Show(metin);
        }
    }
}
