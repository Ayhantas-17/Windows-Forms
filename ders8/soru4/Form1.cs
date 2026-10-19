using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string yol;
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() ==DialogResult.OK)
            {
                yol = folderBrowserDialog1.SelectedPath;
                textBox2.Text = yol;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string belgeadi =textBox1.Text;
            File.CreateText(yol + "\\" + belgeadi + ".docx");
            MessageBox.Show("belge oluşturuldu");
        }
    }
}
