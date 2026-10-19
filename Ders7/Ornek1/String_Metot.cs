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
    public partial class String_Metot : Form
    {
        public String_Metot()
        {
            InitializeComponent();
        }
        string metin;
        private void button1_Click(object sender, EventArgs e)
        {
            metin = richTextBox1.Text;
            listBox1.Items.Add(metin.Length); // metnin uzunluğunu verir.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metin = richTextBox1.Text;
            listBox1.Items.Add(metin.IndexOf("talip"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            metin = richTextBox1.Text;
            listBox1.Items.Add(metin.Trim());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            metin = richTextBox1.Text;
            listBox1.Items.Add(metin.ToUpper());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            metin = richTextBox1.Text;
            listBox1.Items.Add(metin.ToLower());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            metin = richTextBox1.Text;
            listBox1.Items.Add(metin.Remove(3,5));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            metin = richTextBox1.Text;
            listBox1.Items.Add(metin.Replace("p", "b"));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            metin = richTextBox1.Text;
            listBox1.Items.Add(metin.Substring(3));
        }
    }
}
