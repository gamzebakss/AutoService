
namespace AutoService
{
    partial class AracProfilForm
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
            this.grpFofograf = new System.Windows.Forms.GroupBox();
            this.pnlFotolar = new System.Windows.Forms.FlowLayoutPanel();
            this.grpTemelBilgiler = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblSasiNo = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDosyalar = new System.Windows.Forms.GroupBox();
            this.btnDosyaSil = new System.Windows.Forms.Button();
            this.picDosya = new System.Windows.Forms.PictureBox();
            this.ddlKlasorler = new System.Windows.Forms.ComboBox();
            this.lstbDosyalar = new System.Windows.Forms.ListBox();
            this.grpYukle = new System.Windows.Forms.GroupBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.Dosyayolu = new System.Windows.Forms.TextBox();
            this.btnGozat = new System.Windows.Forms.Button();
            this.autoServiceDataSet1 = new AutoService.AutoServiceDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnresimGozat = new System.Windows.Forms.Button();
            this.btnresimYukle = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnresimSil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.grpFofograf.SuspendLayout();
            this.grpTemelBilgiler.SuspendLayout();
            this.grpDosyalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDosya)).BeginInit();
            this.grpYukle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFofograf
            // 
            this.grpFofograf.BackColor = System.Drawing.Color.Transparent;
            this.grpFofograf.Controls.Add(this.pnlFotolar);
            this.grpFofograf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpFofograf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpFofograf.Location = new System.Drawing.Point(477, 43);
            this.grpFofograf.Name = "grpFofograf";
            this.grpFofograf.Size = new System.Drawing.Size(219, 602);
            this.grpFofograf.TabIndex = 0;
            this.grpFofograf.TabStop = false;
            this.grpFofograf.Text = "Fotoğraflar";
            // 
            // pnlFotolar
            // 
            this.pnlFotolar.AutoScroll = true;
            this.pnlFotolar.Location = new System.Drawing.Point(13, 21);
            this.pnlFotolar.Name = "pnlFotolar";
            this.pnlFotolar.Size = new System.Drawing.Size(195, 575);
            this.pnlFotolar.TabIndex = 0;
            // 
            // grpTemelBilgiler
            // 
            this.grpTemelBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.grpTemelBilgiler.Controls.Add(this.label10);
            this.grpTemelBilgiler.Controls.Add(this.label9);
            this.grpTemelBilgiler.Controls.Add(this.label8);
            this.grpTemelBilgiler.Controls.Add(this.label7);
            this.grpTemelBilgiler.Controls.Add(this.label5);
            this.grpTemelBilgiler.Controls.Add(this.lblPlaka);
            this.grpTemelBilgiler.Controls.Add(this.lblSasiNo);
            this.grpTemelBilgiler.Controls.Add(this.lblModel);
            this.grpTemelBilgiler.Controls.Add(this.lblYil);
            this.grpTemelBilgiler.Controls.Add(this.lblRenk);
            this.grpTemelBilgiler.Controls.Add(this.label6);
            this.grpTemelBilgiler.Controls.Add(this.label4);
            this.grpTemelBilgiler.Controls.Add(this.label3);
            this.grpTemelBilgiler.Controls.Add(this.label2);
            this.grpTemelBilgiler.Controls.Add(this.label1);
            this.grpTemelBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpTemelBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpTemelBilgiler.Location = new System.Drawing.Point(47, 43);
            this.grpTemelBilgiler.Name = "grpTemelBilgiler";
            this.grpTemelBilgiler.Size = new System.Drawing.Size(348, 239);
            this.grpTemelBilgiler.TabIndex = 1;
            this.grpTemelBilgiler.TabStop = false;
            this.grpTemelBilgiler.Text = "Temel Bilgiler";
            this.grpTemelBilgiler.Enter += new System.EventHandler(this.grpTemelBilgiler_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(95, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(95, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(95, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(95, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(95, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.ForeColor = System.Drawing.Color.Black;
            this.lblPlaka.Location = new System.Drawing.Point(117, 55);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(46, 16);
            this.lblPlaka.TabIndex = 10;
            this.lblPlaka.Text = "Plaka ";
            // 
            // lblSasiNo
            // 
            this.lblSasiNo.AutoSize = true;
            this.lblSasiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSasiNo.ForeColor = System.Drawing.Color.Black;
            this.lblSasiNo.Location = new System.Drawing.Point(117, 181);
            this.lblSasiNo.Name = "lblSasiNo";
            this.lblSasiNo.Size = new System.Drawing.Size(56, 16);
            this.lblSasiNo.TabIndex = 9;
            this.lblSasiNo.Text = "Şasi No";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(117, 84);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 16);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.ForeColor = System.Drawing.Color.Black;
            this.lblYil.Location = new System.Drawing.Point(117, 115);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(23, 16);
            this.lblYil.TabIndex = 7;
            this.lblYil.Text = "Yıl";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.ForeColor = System.Drawing.Color.Black;
            this.lblRenk.Location = new System.Drawing.Point(117, 147);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(40, 16);
            this.lblRenk.TabIndex = 6;
            this.lblRenk.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şasi No ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yıl ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Renk ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka ";
            // 
            // grpDosyalar
            // 
            this.grpDosyalar.BackColor = System.Drawing.Color.Transparent;
            this.grpDosyalar.Controls.Add(this.btnDosyaSil);
            this.grpDosyalar.Controls.Add(this.picDosya);
            this.grpDosyalar.Controls.Add(this.ddlKlasorler);
            this.grpDosyalar.Controls.Add(this.lstbDosyalar);
            this.grpDosyalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDosyalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpDosyalar.Location = new System.Drawing.Point(47, 310);
            this.grpDosyalar.Name = "grpDosyalar";
            this.grpDosyalar.Size = new System.Drawing.Size(266, 277);
            this.grpDosyalar.TabIndex = 2;
            this.grpDosyalar.TabStop = false;
            this.grpDosyalar.Text = "Dosyalar";
            // 
            // btnDosyaSil
            // 
            this.btnDosyaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaSil.ForeColor = System.Drawing.Color.Black;
            this.btnDosyaSil.Location = new System.Drawing.Point(83, 247);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(74, 23);
            this.btnDosyaSil.TabIndex = 4;
            this.btnDosyaSil.Text = "Dosya Sil";
            this.btnDosyaSil.UseVisualStyleBackColor = true;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // picDosya
            // 
            this.picDosya.BackgroundImage = global::AutoService.Properties.Resources.pngegg;
            this.picDosya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDosya.Location = new System.Drawing.Point(10, 21);
            this.picDosya.Name = "picDosya";
            this.picDosya.Size = new System.Drawing.Size(50, 45);
            this.picDosya.TabIndex = 2;
            this.picDosya.TabStop = false;
            this.picDosya.Click += new System.EventHandler(this.grupYukle_Click);
            // 
            // ddlKlasorler
            // 
            this.ddlKlasorler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ddlKlasorler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKlasorler.FormattingEnabled = true;
            this.ddlKlasorler.Location = new System.Drawing.Point(61, 30);
            this.ddlKlasorler.Name = "ddlKlasorler";
            this.ddlKlasorler.Size = new System.Drawing.Size(182, 24);
            this.ddlKlasorler.TabIndex = 1;
            this.ddlKlasorler.SelectedIndexChanged += new System.EventHandler(this.ddlKlasorler_SelectedIndexChanged);
            // 
            // lstbDosyalar
            // 
            this.lstbDosyalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstbDosyalar.FormattingEnabled = true;
            this.lstbDosyalar.ItemHeight = 16;
            this.lstbDosyalar.Location = new System.Drawing.Point(17, 77);
            this.lstbDosyalar.Name = "lstbDosyalar";
            this.lstbDosyalar.Size = new System.Drawing.Size(226, 164);
            this.lstbDosyalar.TabIndex = 0;
            this.lstbDosyalar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstbDosyalar_MouseClick);
            this.lstbDosyalar.SelectedIndexChanged += new System.EventHandler(this.lstbDosyalar_SelectedIndexChanged);
            this.lstbDosyalar.DoubleClick += new System.EventHandler(this.lstbDosyalar_DoubleClick);
            // 
            // grpYukle
            // 
            this.grpYukle.BackColor = System.Drawing.Color.Transparent;
            this.grpYukle.Controls.Add(this.btnYukle);
            this.grpYukle.Controls.Add(this.Dosyayolu);
            this.grpYukle.Controls.Add(this.btnGozat);
            this.grpYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpYukle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpYukle.Location = new System.Drawing.Point(47, 310);
            this.grpYukle.Name = "grpYukle";
            this.grpYukle.Size = new System.Drawing.Size(266, 96);
            this.grpYukle.TabIndex = 3;
            this.grpYukle.TabStop = false;
            this.grpYukle.Text = "Yükle";
            this.grpYukle.Visible = false;
            // 
            // btnYukle
            // 
            this.btnYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukle.ForeColor = System.Drawing.Color.Black;
            this.btnYukle.Location = new System.Drawing.Point(195, 43);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(65, 23);
            this.btnYukle.TabIndex = 2;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // Dosyayolu
            // 
            this.Dosyayolu.Location = new System.Drawing.Point(85, 44);
            this.Dosyayolu.Name = "Dosyayolu";
            this.Dosyayolu.Size = new System.Drawing.Size(105, 22);
            this.Dosyayolu.TabIndex = 1;
            // 
            // btnGozat
            // 
            this.btnGozat.BackColor = System.Drawing.Color.Silver;
            this.btnGozat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGozat.ForeColor = System.Drawing.Color.Black;
            this.btnGozat.Location = new System.Drawing.Point(6, 43);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(75, 23);
            this.btnGozat.TabIndex = 0;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = false;
            this.btnGozat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // autoServiceDataSet1
            // 
            this.autoServiceDataSet1.DataSetName = "AutoServiceDataSet";
            this.autoServiceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnresimGozat
            // 
            this.btnresimGozat.BackColor = System.Drawing.Color.Silver;
            this.btnresimGozat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnresimGozat.ForeColor = System.Drawing.Color.Black;
            this.btnresimGozat.Location = new System.Drawing.Point(483, 651);
            this.btnresimGozat.Name = "btnresimGozat";
            this.btnresimGozat.Size = new System.Drawing.Size(70, 23);
            this.btnresimGozat.TabIndex = 3;
            this.btnresimGozat.Text = "Gözat";
            this.btnresimGozat.UseVisualStyleBackColor = false;
            this.btnresimGozat.Click += new System.EventHandler(this.btnresimGozat_Click);
            // 
            // btnresimYukle
            // 
            this.btnresimYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnresimYukle.ForeColor = System.Drawing.Color.Black;
            this.btnresimYukle.Location = new System.Drawing.Point(628, 651);
            this.btnresimYukle.Name = "btnresimYukle";
            this.btnresimYukle.Size = new System.Drawing.Size(63, 23);
            this.btnresimYukle.TabIndex = 3;
            this.btnresimYukle.Text = "Yükle";
            this.btnresimYukle.UseVisualStyleBackColor = true;
            this.btnresimYukle.Click += new System.EventHandler(this.btnresimYukle_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnresimSil
            // 
            this.btnresimSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnresimSil.ForeColor = System.Drawing.Color.Black;
            this.btnresimSil.Location = new System.Drawing.Point(559, 651);
            this.btnresimSil.Name = "btnresimSil";
            this.btnresimSil.Size = new System.Drawing.Size(63, 23);
            this.btnresimSil.TabIndex = 5;
            this.btnresimSil.Text = "Sil";
            this.btnresimSil.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(-1, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(722, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "Araç Profil________________________________________________________";
            // 
            // AracProfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.arkaplan23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 686);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnresimSil);
            this.Controls.Add(this.btnresimYukle);
            this.Controls.Add(this.btnresimGozat);
            this.Controls.Add(this.grpYukle);
            this.Controls.Add(this.grpDosyalar);
            this.Controls.Add(this.grpTemelBilgiler);
            this.Controls.Add(this.grpFofograf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracProfilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracProfilForm";
            this.Load += new System.EventHandler(this.AracProfilForm_Load);
            this.grpFofograf.ResumeLayout(false);
            this.grpTemelBilgiler.ResumeLayout(false);
            this.grpTemelBilgiler.PerformLayout();
            this.grpDosyalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDosya)).EndInit();
            this.grpYukle.ResumeLayout(false);
            this.grpYukle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFofograf;
        private System.Windows.Forms.GroupBox grpTemelBilgiler;
        private System.Windows.Forms.GroupBox grpDosyalar;
        private System.Windows.Forms.GroupBox grpYukle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblSasiNo;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picDosya;
        private System.Windows.Forms.ComboBox ddlKlasorler;
        private System.Windows.Forms.ListBox lstbDosyalar;
        private AutoServiceDataSet autoServiceDataSet1;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.TextBox Dosyayolu;
        private System.Windows.Forms.FlowLayoutPanel pnlFotolar;
        private System.Windows.Forms.Button btnresimGozat;
        private System.Windows.Forms.Button btnresimYukle;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnDosyaSil;
        private System.Windows.Forms.Button btnresimSil;
        private System.Windows.Forms.Label label11;
    }
}