using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otelRezervasyonSistemi_Odev.DAL;
using otelRezervasyonSistemi_Odev.ENTİTYLAYER;

namespace otelRezervasyonSistemi_Odev.bl
{
    internal class blmusterikayit
    {
        internal void rezkaydet(string musteriisim, string musterisoyad, long musteritckimlik, int odanumarasi, string giristarihi, string cikistarihi, string odatipi, long telefonnumarasi, string cinsiyet)
        {

            (new MusteriDAL()).rezervasyonkayit(new elMusteriKayit(musteriisim, musterisoyad, musteritckimlik, odanumarasi, giristarihi, cikistarihi, odatipi, telefonnumarasi, cinsiyet));
        }
        public DataTable databilgial()
        {
            MusteriDAL data = new MusteriDAL();
            return data.ver();
        }
        internal void rezervasyonsil(long a)
        {
            (new MusteriDAL()).rezervazyonsil(a);
        }
        private MusteriDAL _dalrez = new MusteriDAL(); 
  
        public bool rezguncelle( string musteriisim, string musterisoyad, long musteritckimlik, int odanumarasi, string giristarihi, string cikistarihi, string odatipi, long telefonnumarasi, string cinsiyet)
        {
            return _dalrez.rezguncelle( musteriisim, musterisoyad, musteritckimlik, odanumarasi, giristarihi, cikistarihi, odatipi, telefonnumarasi, cinsiyet);
        }
    }
}

  