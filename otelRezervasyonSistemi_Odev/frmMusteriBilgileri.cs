using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otelRezervasyonSistemi_Odev.bl;

namespace otelRezervasyonSistemi_Odev
{
    public partial class frmMusteriBilgileri : Form
    {
        public frmMusteriBilgileri()
        {
            InitializeComponent();
        }

        private void mtbTelefonNumarasi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frmMusteriBilgileri_Load(object sender, EventArgs e)
        {
            blmusterikayit blk = new blmusterikayit();
            DataTable data = blk.databilgial();
            dataGridView1.DataSource = data;
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmOdalar odalarForm = new frmOdalar(); // Yeni formu oluştur
            odalarForm.Show(); // Yeni formu göster
            this.Close(); // Mevcut formu kapat
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frm = new frmMusteriKayit();
            frm.Show();
            this.Close();
        }
    }
}
