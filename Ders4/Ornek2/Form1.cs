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
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            int sayi =Convert.ToInt32(textBox1.Text);
            int toplam = 0; int carpim = 1;
            if (rbtnToplama.Checked)
            {
                for (int i = 1; i <= sayi; i++)
                {
                   // toplam = toplam + i;
                    toplam += i;
                }
                listBox1.Items.Add("Toplam= "+toplam.ToString());
            }
            else if (rbtnCarpma.Checked)
            {
                for (int i = 1; i <= sayi; i++)
                {
                    //carpim = carpim * i;
                    carpim *= i;
                }
                listBox1.Items.Add("Faktoriyel= "+carpim.ToString());
            }
            
        }
    }
}
