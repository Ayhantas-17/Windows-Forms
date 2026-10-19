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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //int baslangic=Convert.ToInt32(tbBaslangic.Text);
            //int bitis = Convert.ToInt32(tbBitis.Text);

            // for (int i=baslangic;i<=bitis; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         listBox1.Items.Add(i);
            //     }
            //     else
            //     {
            //         listBox2.Items.Add(i);
            //     }
            // }
            // dizi oluştur ve for each ile bu dizi elemanlarını list boxlaa ekle
            int baslangic = Convert.ToInt32(tbBaslangic.Text);
            int bitis = Convert.ToInt32(tbBitis.Text);
            int boyut = bitis - baslangic + 1;
            int[] Sayilar = new int[boyut];

            int k = 0;
            for (int i = baslangic; i <= bitis; i++)
            {
                Sayilar[k] = i;
                k += 1;
            }

            foreach (int i in Sayilar)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                else
                {
                    listBox2.Items.Add(i);
                }
            }
        }
    }
}
