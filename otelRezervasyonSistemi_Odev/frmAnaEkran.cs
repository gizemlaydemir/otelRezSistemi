using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelRezervasyonSistemi_Odev
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOdalar odalarForm = new frmOdalar(); // Yeni formu oluştur
            odalarForm.Show(); // Yeni formu göster
            this.Hide(); // Bu formu gizle (isteğe bağlı)
        }

        private void btnYöneticiGiris_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris yoneticiGirisForm = new frmYoneticiGiris(); // Yeni formu oluştur
            yoneticiGirisForm.Show(); // Yeni formu göster
            this.Hide(); // Bu formu gizle 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriKayit musterikayitForm = new frmMusteriKayit(); // Yeni formu oluştur
            musterikayitForm.Show(); // Yeni formu göster
            this.Hide(); // Bu formu gizle 
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
