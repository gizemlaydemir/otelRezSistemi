using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelRezervasyonSistemi_Odev.ENTİTYLAYER
{
    internal class elgiris
    {
        private string KullaniciGirisi;
        private string SifreGirisi;

        public string KULLANİCİGİRİSİ { get { return KullaniciGirisi; } set { KullaniciGirisi = value; } }
        public string SİFREGİRİSİ { get { return SifreGirisi; } set { SifreGirisi = value; } }
       
        public elgiris(string muterigirisKullanici, string musterigirisSifre)
        {
            this.KullaniciGirisi = KullaniciGirisi;
            this.SifreGirisi = SifreGirisi;
        }
        public override string ToString()
        {
            return this.KullaniciGirisi + "-" + this.SifreGirisi;
        }








    }
}
