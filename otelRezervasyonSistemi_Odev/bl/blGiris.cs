using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otelRezervasyonSistemi_Odev.DAL;
using otelRezervasyonSistemi_Odev.ENTİTYLAYER;

namespace otelRezervasyonSistemi_Odev.bl
{
    internal class blGiris
    {
        internal void yoneticibilgi(string KullaniciGirisi,string SifreGirisi)
        {
            (new dalGiris()).YoneticiGirisi(new elgiris(KullaniciGirisi,SifreGirisi));
        }
    }
}
