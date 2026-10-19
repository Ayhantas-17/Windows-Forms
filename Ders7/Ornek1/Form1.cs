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

        private void btnSurec_Click(object sender, EventArgs e)
        {
            Surec surec = new Surec();
            surec.ShowDialog();
        }

        private void btnMatematik_Click(object sender, EventArgs e)
        {
            Matematik mtmtk = new Matematik();
            mtmtk.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String_Metot strMetot = new String_Metot();
            strMetot.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TarihZaman trhzmn = new TarihZaman();
            trhzmn.ShowDialog();
        }
    }
}
