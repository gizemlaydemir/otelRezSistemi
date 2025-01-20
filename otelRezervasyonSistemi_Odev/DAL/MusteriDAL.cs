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
        public void rezervazyonsil(long a)
        {
            new MySqlCommand("delete from MUSTERİ where musteritckimlik=" + a, (new DbBaglanti()).BaglantiCagır()).ExecuteReader();
       
        }
        private string connectionstring = "Server=172.21.54.253; Database=25_132330052; Uid=25_132330052; Pwd=!nif.ogr52AY";

        public bool rezguncelle( string musteriisim, string musterisoyad, long musteritckimlik, int odanumarasi, string giristarihi, string cikistarihi, string odatipi, long telefonnumarasi, string cinsiyet)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                string query = "update MUSTERİ set musteriisim=@isim,musterisoyad=@soyad,musteritckimlik=@tc,odanumarasi=@odanu,giristarihi=@gir,cikistarihi=@cik,odatipi=@odatip,telefonnumarasi=@telnu,cinsiyet=@cinsiyet where musteritckimlik=@tc";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@isim", musteriisim);
                cmd.Parameters.AddWithValue("@soyad", musterisoyad);
                cmd.Parameters.AddWithValue("@tc", musteritckimlik);
                cmd.Parameters.AddWithValue("@odanu", odanumarasi);
                cmd.Parameters.AddWithValue("@gir", giristarihi);
                cmd.Parameters.AddWithValue("@cik", cikistarihi);
                cmd.Parameters.AddWithValue("@odatip", odatipi);
                cmd.Parameters.AddWithValue("@telnu", telefonnumarasi);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}