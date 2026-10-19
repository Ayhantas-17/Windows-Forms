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
        int sayac;
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;
            lblSaniye.Visible= true;    
            lblSaniye.Text = sayac.ToString();
            if (sayac > 0 && sayac < 30)
            {
                this.BackColor = Color.Red;
            }
            else if (sayac>=30 && sayac < 50)
            {
                this.BackColor = Color.Yellow;
            }
            else if (sayac>=50 && sayac<80) 
            {
                this.BackColor = Color.Green;
            }
            else if (sayac == 80)
            {
                sayac = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSaniye.Visible = false;
        }
    }
}
