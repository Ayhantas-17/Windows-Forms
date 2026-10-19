using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Text = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Dosya Seçiniz";
            openFileDialog1.Filter = "resim dosyaları (*.jpeg) |*.jpg| metin dosyaları (*.docx)|*.docx";
            openFileDialog1.Title = "lütfen bir dosya seçiniz";
            openFileDialog1.InitialDirectory = "C:";
        }
    }
}
