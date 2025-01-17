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
    public partial class frmKisiKayit2 : Form
    {
        public frmKisiKayit2()
        {
            InitializeComponent();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmKisiKayit frm = new frmKisiKayit();
            frm.Show();
            this.Close();
        }
    }
}
