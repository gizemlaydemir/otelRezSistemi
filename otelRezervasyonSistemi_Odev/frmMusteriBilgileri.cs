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
using otelRezervasyonSistemi_Odev.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otelRezervasyonSistemi_Odev
{
    public partial class frmMusteriBilgileri : Form
    {
        private blmusterikayit rez = new blmusterikayit();
        public frmMusteriBilgileri()
        {
            InitializeComponent();
        }

        private void mtbTelefonNumarasi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string musteriisim = txtIsim.Text;
            string musterisoyad = txtSoyad.Text;
            long musteritckimlik = Convert.ToInt64(txtTcKimlik.Text);
            int odanumarasi = Convert.ToInt32(txtOdaNumarasi.Text);
            string giristarihi = dtpGirisTarihi.Text;
            string cikistarihi = dtpCikisTarihi.Text;
            string odatipi = cbodatipii.Text;
            long telefonnumarasi = Convert.ToInt64(textBox2.Text);
            string cinsiyet = cbcinsiyet.Text;

            bool isUpdated = rez.rezguncelle(musteriisim, musterisoyad, musteritckimlik, odanumarasi, giristarihi, cikistarihi , odatipi , telefonnumarasi, cinsiyet);
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

        private void button3_Click(object sender, EventArgs e)
        {
            (new MusteriDAL()).rezervazyonsil(Convert.ToInt64(txtTcKimlik.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtIsim.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtTcKimlik.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtOdaNumarasi.Text =   dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dtpGirisTarihi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dtpCikisTarihi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cbcinsiyet.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            }
        }

        private void cbodatipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
