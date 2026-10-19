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

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(tbBaslangic.Text);
            int bitis=Convert.ToInt32(tbBitis.Text);
            int sayac;
            //for (int i=baslangic; i<=bitis; i++)
            //{
            //    richTextBox1.Text=richTextBox1.Text+","+ i.ToString();
            //}

            sayac = baslangic;
            //while (sayac <= bitis)
            //{
            //    richTextBox1.Text = richTextBox1.Text + "," + sayac.ToString();
            //    sayac ++;
            //}

            do
            {
                richTextBox1.Text = richTextBox1.Text + "," + sayac.ToString();
                sayac++;
            } while (sayac <= bitis);


        }
    }
}
