using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otelRezervasyonSistemi_Odev.DAL
{
    public class DbBaglanti
    {
        public MySqlConnection BaglantiCagır()
        {

            
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330052; Uid=25_132330052; Pwd=!nif.ogr52AY");
                baglanti.Open();
                return baglanti;
            
            
        }
    }
}
