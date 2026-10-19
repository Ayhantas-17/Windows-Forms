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
    public partial class Surec : Form
    {
        public Surec()
        {
            InitializeComponent();
        }

        private void btnArttir10_Click(object sender, EventArgs e)
        {
         
            try
            {
                progressBar1.Value += 10;
            }
            catch
            {
                MessageBox.Show("Progress Bar Doldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             //progressBar1.Value += 10;
        }

        private void btnAzalt10_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value -= 10;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                MessageBox.Show("Güle güle");
            }
          
        }
    }
}
