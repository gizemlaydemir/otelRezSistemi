using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using otelRezervasyonSistemi_Odev.ENTİTYLAYER;

namespace otelRezervasyonSistemi_Odev.DAL
{
    internal class MusteriDAL
    {
        public void rezervasyonkayit(elMusteriKayit a)
        {
            new MySqlCommand("insert into MUSTERİ (musteriisim,musterisoyad,musteritckimlik,odanumarasi,giristarihi,cikistarihi,odatipi,telefonnumarasi,cinsiyet) values ('" + a.MUSTERİİSİM + "','" + a.MUSTERİSOYAD + "','" + a.MUSTERİTCKİMLİK + "','" + a.ODANUMARASİ + "','" + a.GIRISTARİHİ + "','" + a.CIKISTARİHİ + "','" + a.ODATİPİ + "','" + a.TELEFONNUMARASİ + "','" + a.CİNSİYET + "')", (new DbBaglanti()).BaglantiCagır()).ExecuteReader();


        }
        public DataTable ver()
        {
            using (MySqlConnection bgl = new MySqlConnection("Server=172.21.54.253; Database=25_132330052; Uid=25_132330052; Pwd=!nif.ogr52AY"))
            {
                using (MySqlCommand komut = new MySqlCommand("select musteriisim,musterisoyad,musteritckimlik,odanumarasi,giristarihi,cikistarihi,odatipi,telefonnumarasi,cinsiyet from MUSTERİ", bgl))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }

        }
    }
}