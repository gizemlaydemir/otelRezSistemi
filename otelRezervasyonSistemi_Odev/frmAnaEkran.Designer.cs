namespace otelRezervasyonSistemi_Odev
{
    partial class frmAnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnYöneticiGiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_UstMenu = new System.Windows.Forms.Panel();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_UstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYöneticiGiris
            // 
            this.btnYöneticiGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnYöneticiGiris.ForeColor = System.Drawing.Color.White;
            this.btnYöneticiGiris.Location = new System.Drawing.Point(49, 159);
            this.btnYöneticiGiris.Name = "btnYöneticiGiris";
            this.btnYöneticiGiris.Size = new System.Drawing.Size(174, 106);
            this.btnYöneticiGiris.TabIndex = 0;
            this.btnYöneticiGiris.Text = "YÖNETİCİ GİRİŞ";
            this.btnYöneticiGiris.UseVisualStyleBackColor = false;
            this.btnYöneticiGiris.Click += new System.EventHandler(this.btnYöneticiGiris_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(283, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 106);
            this.button1.TabIndex = 1;
            this.button1.Text = "REZERVASYON";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(512, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 106);
            this.button2.TabIndex = 2;
            this.button2.Text = "ODALAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnl_UstMenu
            // 
            this.pnl_UstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.pnl_UstMenu.Controls.Add(this.Btn_Cikis);
            this.pnl_UstMenu.Controls.Add(this.label1);
            this.pnl_UstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_UstMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_UstMenu.Name = "pnl_UstMenu";
            this.pnl_UstMenu.Size = new System.Drawing.Size(741, 50);
            this.pnl_UstMenu.TabIndex = 3;
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.Btn_Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cikis.ForeColor = System.Drawing.Color.White;
            this.Btn_Cikis.Location = new System.Drawing.Point(702, 11);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(32, 32);
            this.Btn_Cikis.TabIndex = 1;
            this.Btn_Cikis.Text = "X";
            this.Btn_Cikis.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ANA PANEL";
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(741, 430);
            this.Controls.Add(this.pnl_UstMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYöneticiGiris);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAnaEkran";
            this.Text = "frmAnaEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.pnl_UstMenu.ResumeLayout(false);
            this.pnl_UstMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYöneticiGiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnl_UstMenu;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Label label1;
    }
}