
namespace AutoService
{
    partial class KullaniciProfil
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictpProfilResmi = new System.Windows.Forms.PictureBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpFotograf = new System.Windows.Forms.GroupBox();
            this.btnYükle = new System.Windows.Forms.Button();
            this.autoServiceDataSet1 = new AutoService.AutoServiceDataSet1();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarTableAdapter = new AutoService.AutoServiceDataSet1TableAdapters.KullanicilarTableAdapter();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.lstbxKullanıcıProfil = new System.Windows.Forms.ListBox();
            this.lblMusteriTipi = new System.Windows.Forms.Label();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracDuzenle = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblKullanıcıProfilGm = new System.Windows.Forms.Label();
            this.lblKullanıcıProfilTicariU = new System.Windows.Forms.Label();
            this.lblKullanıcıProfilEmail = new System.Windows.Forms.Label();
            this.lblKullanıcıProfilVergiN = new System.Windows.Forms.Label();
            this.lblKullanıcıProfilAdres = new System.Windows.Forms.Label();
            this.pnlKurumsal = new System.Windows.Forms.Panel();
            this.lblVergiDairesi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.autoServiceDataSet3 = new AutoService.AutoServiceDataSet3();
            this.araclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.araclarTableAdapter = new AutoService.AutoServiceDataSet3TableAdapters.AraclarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictpProfilResmi)).BeginInit();
            this.grpFotograf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            this.pnlKurumsal.SuspendLayout();
            this.pnlKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Profil__________________________________________________________";
            // 
            // pictpProfilResmi
            // 
            this.pictpProfilResmi.BackgroundImage = global::AutoService.Properties.Resources.kullaniciprofil1;
            this.pictpProfilResmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictpProfilResmi.Location = new System.Drawing.Point(20, 22);
            this.pictpProfilResmi.Name = "pictpProfilResmi";
            this.pictpProfilResmi.Size = new System.Drawing.Size(130, 141);
            this.pictpProfilResmi.TabIndex = 11;
            this.pictpProfilResmi.TabStop = false;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(16, 17);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(84, 16);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Ad Soyad :";
      
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vergi No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ticari Ünvan :";
         
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gsm :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Adres  :";
            
            // 
            // grpFotograf
            // 
            this.grpFotograf.BackColor = System.Drawing.Color.Transparent;
            this.grpFotograf.Controls.Add(this.pictpProfilResmi);
            this.grpFotograf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpFotograf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpFotograf.Location = new System.Drawing.Point(620, 50);
            this.grpFotograf.Name = "grpFotograf";
            this.grpFotograf.Size = new System.Drawing.Size(169, 175);
            this.grpFotograf.TabIndex = 22;
            this.grpFotograf.TabStop = false;
            this.grpFotograf.Text = "Fotoğraf";
        
            // 
            // btnYükle
            // 
            this.btnYükle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYükle.Location = new System.Drawing.Point(642, 231);
            this.btnYükle.Name = "btnYükle";
            this.btnYükle.Size = new System.Drawing.Size(130, 27);
            this.btnYükle.TabIndex = 23;
            this.btnYükle.Text = "Yükle";
            this.btnYükle.UseVisualStyleBackColor = true;
            this.btnYükle.Click += new System.EventHandler(this.btnYükle_Click);
            // 
            // autoServiceDataSet1
            // 
            this.autoServiceDataSet1.DataSetName = "AutoServiceDataSet1";
            this.autoServiceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "Kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.autoServiceDataSet1;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // btnAracListele
            // 
            this.btnAracListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracListele.Location = new System.Drawing.Point(608, 352);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(130, 27);
            this.btnAracListele.TabIndex = 25;
            this.btnAracListele.Text = "Araç Listele";
            this.btnAracListele.UseVisualStyleBackColor = true;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // lstbxKullanıcıProfil
            // 
            this.lstbxKullanıcıProfil.FormattingEnabled = true;
            this.lstbxKullanıcıProfil.Location = new System.Drawing.Point(42, 314);
            this.lstbxKullanıcıProfil.Name = "lstbxKullanıcıProfil";
            this.lstbxKullanıcıProfil.Size = new System.Drawing.Size(560, 251);
            this.lstbxKullanıcıProfil.TabIndex = 26;
          
            // 
            // lblMusteriTipi
            // 
            this.lblMusteriTipi.BackColor = System.Drawing.Color.Transparent;
            this.lblMusteriTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriTipi.Location = new System.Drawing.Point(435, 46);
            this.lblMusteriTipi.Name = "lblMusteriTipi";
            this.lblMusteriTipi.Size = new System.Drawing.Size(100, 23);
            this.lblMusteriTipi.TabIndex = 27;
            this.lblMusteriTipi.Text = "BİREYSEL";
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkle.Location = new System.Drawing.Point(608, 395);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(130, 27);
            this.btnAracEkle.TabIndex = 28;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracDuzenle
            // 
            this.btnAracDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracDuzenle.Location = new System.Drawing.Point(608, 442);
            this.btnAracDuzenle.Name = "btnAracDuzenle";
            this.btnAracDuzenle.Size = new System.Drawing.Size(130, 27);
            this.btnAracDuzenle.TabIndex = 29;
            this.btnAracDuzenle.Text = "Araç Düzenle";
            this.btnAracDuzenle.UseVisualStyleBackColor = true;
            
            // 
            // btnAracSil
            // 
            this.btnAracSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracSil.Location = new System.Drawing.Point(608, 484);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(130, 27);
            this.btnAracSil.TabIndex = 30;
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(106, 19);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(50, 13);
            this.lblAdSoyad.TabIndex = 31;
            this.lblAdSoyad.Text = "AdSoyad";
            // 
            // lblKullanıcıProfilGm
            // 
            this.lblKullanıcıProfilGm.AutoSize = true;
            this.lblKullanıcıProfilGm.Location = new System.Drawing.Point(106, 51);
            this.lblKullanıcıProfilGm.Name = "lblKullanıcıProfilGm";
            this.lblKullanıcıProfilGm.Size = new System.Drawing.Size(26, 13);
            this.lblKullanıcıProfilGm.TabIndex = 32;
            this.lblKullanıcıProfilGm.Text = "gsm";
            // 
            // lblKullanıcıProfilTicariU
            // 
            this.lblKullanıcıProfilTicariU.AutoSize = true;
            this.lblKullanıcıProfilTicariU.Location = new System.Drawing.Point(123, 49);
            this.lblKullanıcıProfilTicariU.Name = "lblKullanıcıProfilTicariU";
            this.lblKullanıcıProfilTicariU.Size = new System.Drawing.Size(61, 13);
            this.lblKullanıcıProfilTicariU.TabIndex = 33;
            this.lblKullanıcıProfilTicariU.Text = "ticariUnvan";
            // 
            // lblKullanıcıProfilEmail
            // 
            this.lblKullanıcıProfilEmail.AutoSize = true;
            this.lblKullanıcıProfilEmail.Location = new System.Drawing.Point(106, 85);
            this.lblKullanıcıProfilEmail.Name = "lblKullanıcıProfilEmail";
            this.lblKullanıcıProfilEmail.Size = new System.Drawing.Size(31, 13);
            this.lblKullanıcıProfilEmail.TabIndex = 34;
            this.lblKullanıcıProfilEmail.Text = "email";
            // 
            // lblKullanıcıProfilVergiN
            // 
            this.lblKullanıcıProfilVergiN.AutoSize = true;
            this.lblKullanıcıProfilVergiN.Location = new System.Drawing.Point(123, 17);
            this.lblKullanıcıProfilVergiN.Name = "lblKullanıcıProfilVergiN";
            this.lblKullanıcıProfilVergiN.Size = new System.Drawing.Size(42, 13);
            this.lblKullanıcıProfilVergiN.TabIndex = 35;
            this.lblKullanıcıProfilVergiN.Text = "vergino";
            // 
            // lblKullanıcıProfilAdres
            // 
            this.lblKullanıcıProfilAdres.AutoSize = true;
            this.lblKullanıcıProfilAdres.Location = new System.Drawing.Point(106, 120);
            this.lblKullanıcıProfilAdres.Name = "lblKullanıcıProfilAdres";
            this.lblKullanıcıProfilAdres.Size = new System.Drawing.Size(33, 13);
            this.lblKullanıcıProfilAdres.TabIndex = 36;
            this.lblKullanıcıProfilAdres.Text = "adres";
            // 
            // pnlKurumsal
            // 
            this.pnlKurumsal.BackColor = System.Drawing.Color.Transparent;
            this.pnlKurumsal.Controls.Add(this.lblVergiDairesi);
            this.pnlKurumsal.Controls.Add(this.label9);
            this.pnlKurumsal.Controls.Add(this.label3);
            this.pnlKurumsal.Controls.Add(this.lblKullanıcıProfilVergiN);
            this.pnlKurumsal.Controls.Add(this.label4);
            this.pnlKurumsal.Controls.Add(this.lblKullanıcıProfilTicariU);
            this.pnlKurumsal.Location = new System.Drawing.Point(330, 72);
            this.pnlKurumsal.Name = "pnlKurumsal";
            this.pnlKurumsal.Size = new System.Drawing.Size(227, 196);
            this.pnlKurumsal.TabIndex = 38;
         
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.AutoSize = true;
            this.lblVergiDairesi.Location = new System.Drawing.Point(123, 87);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Size = new System.Drawing.Size(62, 13);
            this.lblVergiDairesi.TabIndex = 37;
            this.lblVergiDairesi.Text = "vergiDairesi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Vergi Dairesi :";
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.BackColor = System.Drawing.Color.Transparent;
            this.pnlKullanici.Controls.Add(this.lblAdSoyad);
            this.pnlKullanici.Controls.Add(this.label6);
            this.pnlKullanici.Controls.Add(this.label5);
            this.pnlKullanici.Controls.Add(this.lblKullanıcıProfilAdres);
            this.pnlKullanici.Controls.Add(this.lblKullanıcıProfilEmail);
            this.pnlKullanici.Controls.Add(this.label7);
            this.pnlKullanici.Controls.Add(this.lblKullanıcıProfilGm);
            this.pnlKullanici.Controls.Add(this.lblAd);
            this.pnlKullanici.Location = new System.Drawing.Point(42, 72);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(247, 196);
            this.pnlKullanici.TabIndex = 39;
            // 
            // autoServiceDataSet3
            // 
            this.autoServiceDataSet3.DataSetName = "AutoServiceDataSet3";
            this.autoServiceDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // araclarBindingSource
            // 
            this.araclarBindingSource.DataMember = "Araclar";
            this.araclarBindingSource.DataSource = this.autoServiceDataSet3;
            // 
            // araclarTableAdapter
            // 
            this.araclarTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.arkaplan2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 598);
            this.Controls.Add(this.pnlKullanici);
            this.Controls.Add(this.pnlKurumsal);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnAracDuzenle);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.lblMusteriTipi);
            this.Controls.Add(this.lstbxKullanıcıProfil);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnYükle);
            this.Controls.Add(this.grpFotograf);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "__KullaniciProfil________________________________________________________________" +
    "__________";
            this.Load += new System.EventHandler(this.KullaniciProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictpProfilResmi)).EndInit();
            this.grpFotograf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            this.pnlKurumsal.ResumeLayout(false);
            this.pnlKurumsal.PerformLayout();
            this.pnlKullanici.ResumeLayout(false);
            this.pnlKullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictpProfilResmi;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpFotograf;
        private System.Windows.Forms.Button btnYükle;
        private AutoServiceDataSet1 autoServiceDataSet1;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private AutoServiceDataSet1TableAdapters.KullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.ListBox lstbxKullanıcıProfil;
        private System.Windows.Forms.Label lblMusteriTipi;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracDuzenle;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblKullanıcıProfilGm;
        private System.Windows.Forms.Label lblKullanıcıProfilTicariU;
        private System.Windows.Forms.Label lblKullanıcıProfilEmail;
        private System.Windows.Forms.Label lblKullanıcıProfilVergiN;
        private System.Windows.Forms.Label lblKullanıcıProfilAdres;
        private System.Windows.Forms.Panel pnlKurumsal;
        private System.Windows.Forms.Label lblVergiDairesi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlKullanici;
        private AutoServiceDataSet3 autoServiceDataSet3;
        private System.Windows.Forms.BindingSource araclarBindingSource;
        private AutoServiceDataSet3TableAdapters.AraclarTableAdapter araclarTableAdapter;
    }
}