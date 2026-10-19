using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1
{
    internal class adsoyad
    {
        public string ad;
        public string soyad { get { return _soyad; } set { _soyad = value.ToUpper(); } }
        private string _soyad;
        private int _vize;
        public int vize
        { 
            get { return _vize; }
            set { if (value>=0 && value <= 100)
                { _vize = value;
                }
            else
                {

                }
        public int final;
        public double ort
        {
            get { return (vize+final)/2; }
        }

        public int ort2
        {
            set { final = value; }
        }
        public string metinOlustur()
        {
            string metin = $"{ad} {soyad} adlı öğrencinin ortalaması: {(vize +final)/2}";
            return metin;
                }
    }
}
