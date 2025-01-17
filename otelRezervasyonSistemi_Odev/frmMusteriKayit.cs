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
    public partial class frmMusteriKayit : Form
    {
        public frmMusteriKayit()
        {
            InitializeComponent();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris frm = new frmYoneticiGiris();
            frm.Show();
            this.Close();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (txtTcKimlik.Text!="" && txtIsim.Text!="" && txtSoyad.Text!="" && txtDogumTarihi.Text!="" && txtTelNo.Text!="")
            {
              
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");

            }
        }


        private void frmKisiKayit2_Load(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //temizlemetuşu
            txtTcKimlik.Text = "";
            txtIsim.Text = "";
            txtSoyad.Text = "";
            txtDogumTarihi.Text = "";
            txtTelNo.Text = "";
            rbErkek.Checked = true;
            rbKadin.Checked = false;









        }

        private void txtTcKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
