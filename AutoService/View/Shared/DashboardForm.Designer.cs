
namespace AutoService
{
    partial class DashboardForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblbasik = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnisEmirleri = new System.Windows.Forms.Button();
            this.btnKullaniciProfil = new System.Windows.Forms.Button();
            this.btMusteriListeleme = new System.Windows.Forms.Button();
            this.btnMusteriKayit = new System.Windows.Forms.Button();
            this.grpBekleyenislemler = new System.Windows.Forms.GroupBox();
            this.pnlBekleyenIsEmirleri = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBekleyenislemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AutoService.Properties.Resources.baslık;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(150, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblbasik
            // 
            this.lblbasik.AutoSize = true;
            this.lblbasik.BackColor = System.Drawing.Color.Transparent;
            this.lblbasik.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbasik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblbasik.Location = new System.Drawing.Point(871, 39);
            this.lblbasik.Name = "lblbasik";
            this.lblbasik.Size = new System.Drawing.Size(242, 35);
            this.lblbasik.TabIndex = 1;
            this.lblbasik.Text = "AUTO SERVİCE";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AutoService.Properties.Resources.arkafon21;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnisEmirleri);
            this.panel1.Controls.Add(this.btnKullaniciProfil);
            this.panel1.Controls.Add(this.btMusteriListeleme);
            this.panel1.Controls.Add(this.btnMusteriKayit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 764);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AutoService.Properties.Resources.pngwing_com__6_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(41, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 84);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.BackgroundImage = global::AutoService.Properties.Resources.yanfon3;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(4, 347);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Size = new System.Drawing.Size(177, 38);
            this.btnDashboard.TabIndex = 13;
            this.btnDashboard.Text = "Dashboard ";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnisEmirleri
            // 
            this.btnisEmirleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnisEmirleri.BackgroundImage = global::AutoService.Properties.Resources.yanfon3;
            this.btnisEmirleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnisEmirleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnisEmirleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnisEmirleri.ForeColor = System.Drawing.Color.White;
            this.btnisEmirleri.Location = new System.Drawing.Point(3, 303);
            this.btnisEmirleri.Name = "btnisEmirleri";
            this.btnisEmirleri.Padding = new System.Windows.Forms.Padding(5);
            this.btnisEmirleri.Size = new System.Drawing.Size(176, 38);
            this.btnisEmirleri.TabIndex = 11;
            this.btnisEmirleri.Text = "İş Emirleri";
            this.btnisEmirleri.UseVisualStyleBackColor = false;
            this.btnisEmirleri.Click += new System.EventHandler(this.btnisEmirleri_Click);
            // 
            // btnKullaniciProfil
            // 
            this.btnKullaniciProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKullaniciProfil.BackgroundImage = global::AutoService.Properties.Resources.yanfon3;
            this.btnKullaniciProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKullaniciProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciProfil.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciProfil.Location = new System.Drawing.Point(4, 259);
            this.btnKullaniciProfil.Name = "btnKullaniciProfil";
            this.btnKullaniciProfil.Padding = new System.Windows.Forms.Padding(5);
            this.btnKullaniciProfil.Size = new System.Drawing.Size(177, 38);
            this.btnKullaniciProfil.TabIndex = 9;
            this.btnKullaniciProfil.Text = "Kullanıcı Profil";
            this.btnKullaniciProfil.UseVisualStyleBackColor = false;
            this.btnKullaniciProfil.Click += new System.EventHandler(this.btnKullaniciProfil_Click);
            // 
            // btMusteriListeleme
            // 
            this.btMusteriListeleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMusteriListeleme.BackgroundImage = global::AutoService.Properties.Resources.yanfon3;
            this.btMusteriListeleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMusteriListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMusteriListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMusteriListeleme.ForeColor = System.Drawing.Color.White;
            this.btMusteriListeleme.Location = new System.Drawing.Point(3, 215);
            this.btMusteriListeleme.Name = "btMusteriListeleme";
            this.btMusteriListeleme.Padding = new System.Windows.Forms.Padding(5);
            this.btMusteriListeleme.Size = new System.Drawing.Size(176, 38);
            this.btMusteriListeleme.TabIndex = 6;
            this.btMusteriListeleme.Text = "Müsteri Listeleme";
            this.btMusteriListeleme.UseVisualStyleBackColor = false;
            this.btMusteriListeleme.Click += new System.EventHandler(this.btMusteriListeleme_Click);
            // 
            // btnMusteriKayit
            // 
            this.btnMusteriKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMusteriKayit.BackgroundImage = global::AutoService.Properties.Resources.yanfon;
            this.btnMusteriKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriKayit.ForeColor = System.Drawing.Color.White;
            this.btnMusteriKayit.Location = new System.Drawing.Point(3, 171);
            this.btnMusteriKayit.Name = "btnMusteriKayit";
            this.btnMusteriKayit.Padding = new System.Windows.Forms.Padding(5);
            this.btnMusteriKayit.Size = new System.Drawing.Size(176, 38);
            this.btnMusteriKayit.TabIndex = 5;
            this.btnMusteriKayit.Text = "Müşteri Kayıt";
            this.btnMusteriKayit.UseVisualStyleBackColor = false;
            this.btnMusteriKayit.Click += new System.EventHandler(this.btnMusteriKayit_Click);
            // 
            // grpBekleyenislemler
            // 
            this.grpBekleyenislemler.BackColor = System.Drawing.Color.Transparent;
            this.grpBekleyenislemler.Controls.Add(this.pnlBekleyenIsEmirleri);
            this.grpBekleyenislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBekleyenislemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpBekleyenislemler.Location = new System.Drawing.Point(190, 77);
            this.grpBekleyenislemler.Name = "grpBekleyenislemler";
            this.grpBekleyenislemler.Size = new System.Drawing.Size(910, 189);
            this.grpBekleyenislemler.TabIndex = 5;
            this.grpBekleyenislemler.TabStop = false;
            this.grpBekleyenislemler.Text = "İşlem Bekleyen Araçlar";
            // 
            // pnlBekleyenIsEmirleri
            // 
            this.pnlBekleyenIsEmirleri.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlBekleyenIsEmirleri.Location = new System.Drawing.Point(6, 21);
            this.pnlBekleyenIsEmirleri.Name = "pnlBekleyenIsEmirleri";
            this.pnlBekleyenIsEmirleri.Size = new System.Drawing.Size(898, 162);
            this.pnlBekleyenIsEmirleri.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.arkaplan2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 764);
            this.Controls.Add(this.grpBekleyenislemler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblbasik);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBekleyenislemler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblbasik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMusteriKayit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnisEmirleri;
        private System.Windows.Forms.Button btnKullaniciProfil;
        private System.Windows.Forms.Button btMusteriListeleme;
        private System.Windows.Forms.GroupBox grpBekleyenislemler;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel pnlBekleyenIsEmirleri;
    }
}