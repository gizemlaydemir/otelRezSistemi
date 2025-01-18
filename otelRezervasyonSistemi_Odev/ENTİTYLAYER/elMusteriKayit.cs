using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using otelRezervasyonSistemi_Odev.bl;
using otelRezervasyonSistemi_Odev.DAL;

namespace otelRezervasyonSistemi_Odev.ENTİTYLAYER
{
    internal class elMusteriKayit
    {
        public string musteriisim;
        public string musterisoyad;
        public long musteritckimlik;
        public int odanumarasi;
        private string giristarihi;
        private string cikistarihi;
        private string odatipi;
        private long telefonnumarasi;
        private string cinsiyet;
       

        public string MUSTERİİSİM { get { return musteriisim; } set { musteriisim = value; } }
        public string MUSTERİSOYAD { get { return musterisoyad; } set { musterisoyad = value; } }
        public long MUSTERİTCKİMLİK { get { return musteritckimlik; } set { musteritckimlik = value; } }
        public int ODANUMARASİ { get { return odanumarasi; } set { odanumarasi = value; } }
        public string GIRISTARİHİ { get { return giristarihi; } set { giristarihi = value; } }
        public string CIKISTARİHİ { get { return cikistarihi; } set { cikistarihi = value; } }
        public string ODATİPİ { get { return odatipi; } set { odatipi = value;  } }
        public long TELEFONNUMARASİ { get { return telefonnumarasi; } set { telefonnumarasi = value; } }
        public string CİNSİYET { get { return cinsiyet; } set { cinsiyet = value; } }

        public elMusteriKayit(string musteriisim, string musterisoyad, long musteritckimlik, int odanumarasi, string giristarihi, string cikistarihi, string odatipi, long telefonnumarasi, string cinsiyet)
      {
            this.musteriisim = musteriisim;
            this.musterisoyad = musterisoyad;
            this.musteritckimlik = musteritckimlik;
            this.odanumarasi = odanumarasi;
            this.giristarihi = giristarihi;
            this.cikistarihi = cikistarihi;
            this.odatipi = odatipi;
            this.telefonnumarasi = telefonnumarasi;
            this.cinsiyet = cinsiyet;
      } 
        public override string ToString()
        {
            return this.musteriisim + "-" + this.musterisoyad + "-" + this.musteritckimlik + "-" + this.odanumarasi + "-" + this.giristarihi + "-" + this.cikistarihi + "-" + this.odatipi + "-" + this.telefonnumarasi + "-" + this.cinsiyet;
        }

    }
}
