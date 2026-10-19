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
    public partial class TarihZaman : Form
    {
        public TarihZaman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dogumGunu = dateTimePicker1.Value; //datetime nesnesinde anlık tarih saklı
            DateTime bugun = DateTime.Now;
            int yil = bugun.Year - dogumGunu.Year;
            string metin1 = $"{yil} yıldır yaşıyorsun.";
            label2.Text = metin1;

            TimeSpan fark = bugun - dogumGunu; // timespan nesnesinde süreç saklı
            string metin2 = $"{fark.Days} gündür yaşıyorsun";
            label3.Text = metin2;
        }
    }
}
