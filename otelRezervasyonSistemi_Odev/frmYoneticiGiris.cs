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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            //kontürelleri sağladıktan sonra sonraki sayfaya geç
            frmMusteriKayit frm = new frmMusteriKayit();
            frm.Show();
            this.Hide();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKulAdi.Text = "";
            txtSifre.Text = "";
        }
    }
}
