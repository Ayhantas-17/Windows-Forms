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

        private void btnGetir_Click(object sender, EventArgs e)
        {
            // string ad = "talip";
            string[] ad = {"Zehra", "Talip", "Zeynep", "Ömer"};


            int Id = 1;
            label1.Text = ad[Id];

           
            //int sayi = new int();
            //sayi = 1;

            //int sayi3;
            //sayi3 = new int();

            // int sayi=new int();
            string[] Adsoyad = new string[4];
            Adsoyad[0] = "Zehra Çelik";
            Adsoyad[1] = "Talip çelik";
            Adsoyad[2] = " Zeynep Çelik";
            Adsoyad[3] = "Ömer çelik";

            label2.Text = Adsoyad[Id];


        }
    }
}
