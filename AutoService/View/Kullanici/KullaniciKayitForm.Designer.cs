
namespace AutoService
{
    partial class KullaniciKayitForm
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
            this.grupTemelBigiler = new System.Windows.Forms.GroupBox();
            this.rdbKurumsal = new System.Windows.Forms.RadioButton();
            this.rdbBireysel = new System.Windows.Forms.RadioButton();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.grupiletisim = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtGsm = new System.Windows.Forms.MaskedTextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblGsm = new System.Windows.Forms.Label();
            this.grupKurumsalBilgiler = new System.Windows.Forms.GroupBox();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.txtVergiD = new System.Windows.Forms.TextBox();
            this.txtTicariU = new System.Windows.Forms.TextBox();
            this.lblVergiN = new System.Windows.Forms.Label();
            this.lblVergiD = new System.Windows.Forms.Label();
            this.lblTicariU = new System.Windows.Forms.Label();
            this.grupGirisBilgiler = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grupTemelBigiler.SuspendLayout();
            this.grupiletisim.SuspendLayout();
            this.grupKurumsalBilgiler.SuspendLayout();
            this.grupGirisBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupTemelBigiler
            // 
            this.grupTemelBigiler.BackColor = System.Drawing.Color.Transparent;
            this.grupTemelBigiler.Controls.Add(this.rdbKurumsal);
            this.grupTemelBigiler.Controls.Add(this.rdbBireysel);
            this.grupTemelBigiler.Controls.Add(this.txtSoyad);
            this.grupTemelBigiler.Controls.Add(this.txtAd);
            this.grupTemelBigiler.Controls.Add(this.lblTip);
            this.grupTemelBigiler.Controls.Add(this.lblSoyad);
            this.grupTemelBigiler.Controls.Add(this.lblAd);
            this.grupTemelBigiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupTemelBigiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grupTemelBigiler.Location = new System.Drawing.Point(24, 71);
            this.grupTemelBigiler.Name = "grupTemelBigiler";
            this.grupTemelBigiler.Size = new System.Drawing.Size(341, 150);
            this.grupTemelBigiler.TabIndex = 0;
            this.grupTemelBigiler.TabStop = false;
            this.grupTemelBigiler.Text = "Temel Bilgiler";
            // 
            // rdbKurumsal
            // 
            this.rdbKurumsal.AutoSize = true;
            this.rdbKurumsal.ForeColor = System.Drawing.Color.Black;
            this.rdbKurumsal.Location = new System.Drawing.Point(173, 113);
            this.rdbKurumsal.Name = "rdbKurumsal";
            this.rdbKurumsal.Size = new System.Drawing.Size(86, 19);
            this.rdbKurumsal.TabIndex = 6;
            this.rdbKurumsal.TabStop = true;
            this.rdbKurumsal.Text = "Kurumsal";
            this.rdbKurumsal.UseVisualStyleBackColor = true;
            this.rdbKurumsal.CheckedChanged += new System.EventHandler(this.rdbKurumsal_CheckedChanged);
            // 
            // rdbBireysel
            // 
            this.rdbBireysel.AutoSize = true;
            this.rdbBireysel.ForeColor = System.Drawing.Color.Black;
            this.rdbBireysel.Location = new System.Drawing.Point(79, 113);
            this.rdbBireysel.Name = "rdbBireysel";
            this.rdbBireysel.Size = new System.Drawing.Size(76, 19);
            this.rdbBireysel.TabIndex = 5;
            this.rdbBireysel.TabStop = true;
            this.rdbBireysel.Text = "Bireysel";
            this.rdbBireysel.UseVisualStyleBackColor = true;
            this.rdbBireysel.CheckedChanged += new System.EventHandler(this.rdbBireysel_CheckedChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(79, 79);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(170, 21);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(79, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(170, 21);
            this.txtAd.TabIndex = 3;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Black;
            this.lblTip.Location = new System.Drawing.Point(17, 113);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(35, 15);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Tip :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblSoyad.Location = new System.Drawing.Point(17, 79);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(54, 15);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(17, 42);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 15);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad :";
            // 
            // grupiletisim
            // 
            this.grupiletisim.BackColor = System.Drawing.Color.Transparent;
            this.grupiletisim.Controls.Add(this.txtAdres);
            this.grupiletisim.Controls.Add(this.txtGsm);
            this.grupiletisim.Controls.Add(this.lblAdres);
            this.grupiletisim.Controls.Add(this.lblGsm);
            this.grupiletisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupiletisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grupiletisim.Location = new System.Drawing.Point(371, 71);
            this.grupiletisim.Name = "grupiletisim";
            this.grupiletisim.Size = new System.Drawing.Size(342, 150);
            this.grupiletisim.TabIndex = 1;
            this.grupiletisim.TabStop = false;
            this.grupiletisim.Text = "İletişim";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(72, 79);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(177, 65);
            this.txtAdres.TabIndex = 9;
            // 
            // txtGsm
            // 
            this.txtGsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGsm.Location = new System.Drawing.Point(79, 42);
            this.txtGsm.Mask = "(999) 000-0000";
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(170, 21);
            this.txtGsm.TabIndex = 7;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.ForeColor = System.Drawing.Color.Black;
            this.lblAdres.Location = new System.Drawing.Point(15, 79);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(51, 15);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres :";
            // 
            // lblGsm
            // 
            this.lblGsm.AutoSize = true;
            this.lblGsm.ForeColor = System.Drawing.Color.Black;
            this.lblGsm.Location = new System.Drawing.Point(15, 42);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(46, 15);
            this.lblGsm.TabIndex = 2;
            this.lblGsm.Text = "GSM :";
            // 
            // grupKurumsalBilgiler
            // 
            this.grupKurumsalBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.grupKurumsalBilgiler.Controls.Add(this.txtVergiNo);
            this.grupKurumsalBilgiler.Controls.Add(this.txtVergiD);
            this.grupKurumsalBilgiler.Controls.Add(this.txtTicariU);
            this.grupKurumsalBilgiler.Controls.Add(this.lblVergiN);
            this.grupKurumsalBilgiler.Controls.Add(this.lblVergiD);
            this.grupKurumsalBilgiler.Controls.Add(this.lblTicariU);
            this.grupKurumsalBilgiler.Enabled = false;
            this.grupKurumsalBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupKurumsalBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grupKurumsalBilgiler.Location = new System.Drawing.Point(372, 256);
            this.grupKurumsalBilgiler.Name = "grupKurumsalBilgiler";
            this.grupKurumsalBilgiler.Size = new System.Drawing.Size(341, 150);
            this.grupKurumsalBilgiler.TabIndex = 3;
            this.grupKurumsalBilgiler.TabStop = false;
            this.grupKurumsalBilgiler.Text = "Kurumsal Bilgiler";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiNo.Location = new System.Drawing.Point(118, 113);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(170, 21);
            this.txtVergiNo.TabIndex = 9;
            // 
            // txtVergiD
            // 
            this.txtVergiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiD.Location = new System.Drawing.Point(118, 79);
            this.txtVergiD.Name = "txtVergiD";
            this.txtVergiD.Size = new System.Drawing.Size(170, 21);
            this.txtVergiD.TabIndex = 8;
            // 
            // txtTicariU
            // 
            this.txtTicariU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTicariU.Location = new System.Drawing.Point(118, 39);
            this.txtTicariU.Name = "txtTicariU";
            this.txtTicariU.Size = new System.Drawing.Size(170, 21);
            this.txtTicariU.TabIndex = 7;
            // 
            // lblVergiN
            // 
            this.lblVergiN.AutoSize = true;
            this.lblVergiN.ForeColor = System.Drawing.Color.Black;
            this.lblVergiN.Location = new System.Drawing.Point(17, 113);
            this.lblVergiN.Name = "lblVergiN";
            this.lblVergiN.Size = new System.Drawing.Size(70, 15);
            this.lblVergiN.TabIndex = 2;
            this.lblVergiN.Text = "Vergi No :";
            // 
            // lblVergiD
            // 
            this.lblVergiD.AutoSize = true;
            this.lblVergiD.ForeColor = System.Drawing.Color.Black;
            this.lblVergiD.Location = new System.Drawing.Point(17, 79);
            this.lblVergiD.Name = "lblVergiD";
            this.lblVergiD.Size = new System.Drawing.Size(98, 15);
            this.lblVergiD.TabIndex = 1;
            this.lblVergiD.Text = "Vergi Dairesi :";
            // 
            // lblTicariU
            // 
            this.lblTicariU.AutoSize = true;
            this.lblTicariU.ForeColor = System.Drawing.Color.Black;
            this.lblTicariU.Location = new System.Drawing.Point(17, 42);
            this.lblTicariU.Name = "lblTicariU";
            this.lblTicariU.Size = new System.Drawing.Size(95, 15);
            this.lblTicariU.TabIndex = 0;
            this.lblTicariU.Text = "Ticari Ünvan :";
            // 
            // grupGirisBilgiler
            // 
            this.grupGirisBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.grupGirisBilgiler.Controls.Add(this.txtSifre);
            this.grupGirisBilgiler.Controls.Add(this.txtEmail);
            this.grupGirisBilgiler.Controls.Add(this.lblSifre);
            this.grupGirisBilgiler.Controls.Add(this.lblMail);
            this.grupGirisBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupGirisBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grupGirisBilgiler.Location = new System.Drawing.Point(24, 256);
            this.grupGirisBilgiler.Name = "grupGirisBilgiler";
            this.grupGirisBilgiler.Size = new System.Drawing.Size(341, 150);
            this.grupGirisBilgiler.TabIndex = 4;
            this.grupGirisBilgiler.TabStop = false;
            this.grupGirisBilgiler.Text = "Giriş Bilgiler";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(79, 79);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(170, 21);
            this.txtSifre.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(79, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 21);
            this.txtEmail.TabIndex = 7;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.Color.Black;
            this.lblSifre.Location = new System.Drawing.Point(17, 79);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 15);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(17, 42);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 15);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "E-Mail :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(175, 464);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(98, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btniptal
            // 
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniptal.Location = new System.Drawing.Point(313, 464);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(98, 23);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(450, 464);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(98, 23);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Kayıt________________________________________________________";
            // 
            // KullaniciKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.arkaplan22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grupGirisBilgiler);
            this.Controls.Add(this.grupKurumsalBilgiler);
            this.Controls.Add(this.grupiletisim);
            this.Controls.Add(this.grupTemelBigiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciKayitForm";
            this.Load += new System.EventHandler(this.KullaniciKayitForm_Load);
            this.grupTemelBigiler.ResumeLayout(false);
            this.grupTemelBigiler.PerformLayout();
            this.grupiletisim.ResumeLayout(false);
            this.grupiletisim.PerformLayout();
            this.grupKurumsalBilgiler.ResumeLayout(false);
            this.grupKurumsalBilgiler.PerformLayout();
            this.grupGirisBilgiler.ResumeLayout(false);
            this.grupGirisBilgiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupTemelBigiler;
        private System.Windows.Forms.GroupBox grupiletisim;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblGsm;
        private System.Windows.Forms.GroupBox grupKurumsalBilgiler;
        private System.Windows.Forms.Label lblVergiN;
        private System.Windows.Forms.Label lblVergiD;
        private System.Windows.Forms.Label lblTicariU;
        private System.Windows.Forms.GroupBox grupGirisBilgiler;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.TextBox txtVergiD;
        private System.Windows.Forms.TextBox txtTicariU;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbKurumsal;
        private System.Windows.Forms.RadioButton rdbBireysel;
        private System.Windows.Forms.MaskedTextBox txtGsm;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
    }
}