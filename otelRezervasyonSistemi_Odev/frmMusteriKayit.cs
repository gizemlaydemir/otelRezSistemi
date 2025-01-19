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
            frmAnaEkran frm = new frmAnaEkran();
            frm.Show();
            this.Close();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            (new blmusterikayit()).rezkaydet(txtIsim.Text, txtSoyad.Text, Convert.ToInt64(txtTcKimlik.Text), Convert.ToInt16(txtOdaNumarasi.Text), dtpGirisTarihi.Text, dtpCikisTarihi.Text, cbodatipi.Text,Convert.ToInt64(txtTelefonNumarasi.Text), cbcinsiyet.Text);


            if (txtTcKimlik.Text != "" && txtIsim.Text != "" && txtSoyad.Text != "" && txtOdaNumarasi.Text != "" )
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
            mtbTelefonNumarasi.Text = "";
            txtSoyad.Text = "";
            txtOdaNumarasi.Text = "";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "103";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "102";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "201";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "106";
        }

        private void txtÜcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "101";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "105";
        }

        private void btnOda202_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "202";
        }

        private void btnOda203_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "203";
        }

        private void btnOda204_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "204";
        }

        private void btnOda205_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "205";
        }

        private void btnOda206_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "206";
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsim_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli odalar doludur.");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli odalar boştur.");
        }

        private void txtTcKimlik_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelNo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            
        }   

        private void lbl0_Click(object sender, EventArgs e)
        {

        }

        private void gbMüsteriKayit_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtbTelefonNumarasi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMusteriBilgileri musteribilgileriForm = new frmMusteriBilgileri(); // Yeni formu oluştur
            musteribilgileriForm.Show(); // Yeni formu göster
            this.Close(); // Mevcut formu kapat

        }
    }
}
