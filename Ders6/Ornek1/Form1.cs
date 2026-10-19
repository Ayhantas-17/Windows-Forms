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

        void Listele() //herhangi bir eriişim belirteci yok yani private
        {
            for (int i=1; i <= 10; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }

        void Ekle(int x)
        {
            lbSayilar2.Items.Add(x);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // 1 ile 10 arasındaki sayıları listeboxa metot ile ekleyen program
            // 2 tip metot var : 1. geriye değer döndürmeyen 2. geriye değer döndüren
            // metotların kullanımı : erişim belirteci-değer döndürme durumu(döndürülen değişkenin türü)-metot adı (değişkenler)
            // metot geri değer döndürmezse void dir.
            // erişim belirteçleri: private: tanımlanan sınıfın içinde erişilebilir
            // erişim belirteçleri: public: tanımlnan sınıf ve dışındaki herkes tarafından erişilebilir
            // erişim belirteçleri: protected: tanımlnan ve tanımlandığı sınıftan miras alan sınıflar erişebilir
            // hiç bir belirteç kullanılmazsa varsayılan olrak private dir.

            Listele();
            for (int i = 1; i <= 10; i++)
            {
                Ekle(i);
            }

        }
    }
}
