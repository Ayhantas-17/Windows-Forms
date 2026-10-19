using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btbEkle_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(sayi);
            
        }
        int[] sayiDizisi;
        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i=0;i<listBox1.Items.Count;i++)
            {
                int sayi = Convert.ToInt32(listBox1.Items[i]);
                toplam = toplam + sayi;
            }

            double ortalama = toplam / listBox1.Items.Count;
            lblOrtalama.Text = ortalama.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            sayiDizisi = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayiDizisi[i] = Convert.ToInt32(listBox1.Items[i]);
            }
             Array.Sort(sayiDizisi);
            
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                listBox2.Items.Add(sayiDizisi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblMax.Text = sayiDizisi.Max().ToString();
            // dizinin maxını bulur
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMin.Text=sayiDizisi.Min().ToString();
            // dizinin min i bulur
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            sayiDizisi = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayiDizisi[i] = Convert.ToInt32(listBox1.Items[i]);
            }

            Array.Reverse(sayiDizisi); //diziyi terse çevirir
           
            //for (int i = 0; i < sayiDizisi.Length; i++)
            //{
            //    listBox3.Items.Add(sayiDizisi[i]);
            //}

            foreach (int i in sayiDizisi)
            {
                listBox3.Items.Add(i);
            }

        }
    }
}
