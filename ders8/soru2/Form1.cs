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

namespace soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            if ( folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                DirectoryInfo klasor = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] belgeler = klasor.GetFiles("*.docx");
                foreach (FileInfo fli in belgeler)
                {
                    listBox1.Items.Add(fli.Name);
                }
            }
        }
    }
}
