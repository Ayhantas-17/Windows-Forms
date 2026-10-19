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

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string ilId = textBox1.Text;
            switch (ilId)
            {
                case "1": MessageBox.Show("İl=Adana","il Gösterimi"); break;
                case "2": MessageBox.Show("İl=Afyon", "il Gösterimi"); break;
                case "17": MessageBox.Show("İl=Çanakkale", "il Gösterimi"); break;
                case "27": MessageBox.Show("İl=Gaziantep", "il Gösterimi"); break;
                default: MessageBox.Show("Lütfen 1-81 arası bir sayı giriniz", "il Gösterimi"); break;


            }
        }
    }
}
