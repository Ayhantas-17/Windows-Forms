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

        int Faktoriyel(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }
            return sayi * Faktoriyel(sayi - 1);
        }

        int Faktoriyel()
        {
            int sayi = Convert.ToInt16(tbSayi.Text);
            int faktor = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktor = faktor * i;
            }
            return faktor;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(tbSayi.Text);
            tbFaktor.Text= Faktoriyel(sayi).ToString();
            tbFak2.Text = Faktoriyel().ToString();
        }
    }
}
