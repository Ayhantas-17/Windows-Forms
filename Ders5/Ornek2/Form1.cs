using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int[,] Sayilar = new int[2, 2];
            Sayilar[0, 0] = 2;
            Sayilar[1, 0] = 4;
            Sayilar[0, 1] = 3;
            Sayilar[1, 1] = 5;

            for (int i = 0; i < Sayilar.GetLength(0); i++)
            {
                for (int j = 0; j < Sayilar.GetLength(1); j++)
                {
                    listBox1.Items.Add(Sayilar[i, j]);
                }
            }

        }
    }
}
