using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using otelRezervasyonSistemi_Odev.bl;
using otelRezervasyonSistemi_Odev.DAL;

namespace otelRezervasyonSistemi_Odev
{
    public partial class frmYoneticiGiris : Form
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void kız_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
        DbBaglanti snf = new DbBaglanti();
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            (new blGiris()).yoneticibilgi(txtKulAdi.Text, txtSifre.Text);
            MySqlCommand komut = new MySqlCommand("select * from YoneticiGirisEkrani where KulaniciAdi =@a1 and KullaniciSifre=@s1",snf.BaglantiCagır());
            komut.Parameters.AddWithValue("@a1", txtKulAdi.Text);
            komut.Parameters.AddWithValue("@s1", txtSifre.Text);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                frmMusteriKayit frm = new frmMusteriKayit();
                frm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler Hatalıdır");
            }
           
            


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKulAdi.Text = "";
            txtSifre.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran();
            frm.Show();
            this.Close();
        }
    }
}
