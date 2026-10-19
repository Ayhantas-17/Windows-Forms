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

        // metodun alacağı parametre sayısı belli değil ise params anahtar kelimesi kullanılır.
        void PasifYap(params Button[] btn)
        {
            for (byte i=0; i <= btn.Length - 1; i++)
            {
                btn[i].Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PasifYap(btn1,btn2,btn3);
        }
    }
}
