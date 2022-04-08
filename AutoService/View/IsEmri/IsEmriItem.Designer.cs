
namespace AutoService
{
    partial class IsEmriItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPlaka = new System.Windows.Forms.Panel();
            this.pnlAcıklama = new System.Windows.Forms.Panel();
            this.pnlGelisSebebi = new System.Windows.Forms.Panel();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblAcıklama = new System.Windows.Forms.Label();
            this.lblGelisSebebi = new System.Windows.Forms.Label();
            this.btnAc = new System.Windows.Forms.Button();
            this.pnlPlaka.SuspendLayout();
            this.pnlAcıklama.SuspendLayout();
            this.pnlGelisSebebi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaka
            // 
            this.pnlPlaka.BackColor = System.Drawing.Color.Silver;
            this.pnlPlaka.Controls.Add(this.lblPlaka);
            this.pnlPlaka.Location = new System.Drawing.Point(0, 2);
            this.pnlPlaka.Name = "pnlPlaka";
            this.pnlPlaka.Size = new System.Drawing.Size(125, 36);
            this.pnlPlaka.TabIndex = 0;
            // 
            // pnlAcıklama
            // 
            this.pnlAcıklama.BackColor = System.Drawing.Color.Silver;
            this.pnlAcıklama.Controls.Add(this.lblAcıklama);
            this.pnlAcıklama.Location = new System.Drawing.Point(131, 2);
            this.pnlAcıklama.Name = "pnlAcıklama";
            this.pnlAcıklama.Size = new System.Drawing.Size(326, 36);
            this.pnlAcıklama.TabIndex = 1;
            // 
            // pnlGelisSebebi
            // 
            this.pnlGelisSebebi.BackColor = System.Drawing.Color.Silver;
            this.pnlGelisSebebi.Controls.Add(this.lblGelisSebebi);
            this.pnlGelisSebebi.Location = new System.Drawing.Point(463, 2);
            this.pnlGelisSebebi.Name = "pnlGelisSebebi";
            this.pnlGelisSebebi.Size = new System.Drawing.Size(208, 36);
            this.pnlGelisSebebi.TabIndex = 1;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.ForeColor = System.Drawing.Color.Maroon;
            this.lblPlaka.Location = new System.Drawing.Point(14, 12);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(52, 13);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "35MF79";
            // 
            // lblAcıklama
            // 
            this.lblAcıklama.AutoSize = true;
            this.lblAcıklama.ForeColor = System.Drawing.Color.Black;
            this.lblAcıklama.Location = new System.Drawing.Point(0, 12);
            this.lblAcıklama.Name = "lblAcıklama";
            this.lblAcıklama.Size = new System.Drawing.Size(255, 13);
            this.lblAcıklama.TabIndex = 1;
            this.lblAcıklama.Text = "Müsteri Şikayetleri buraya gelecek ama uzun gelebilir";
            // 
            // lblGelisSebebi
            // 
            this.lblGelisSebebi.AutoSize = true;
            this.lblGelisSebebi.ForeColor = System.Drawing.Color.Black;
            this.lblGelisSebebi.Location = new System.Drawing.Point(3, 12);
            this.lblGelisSebebi.Name = "lblGelisSebebi";
            this.lblGelisSebebi.Size = new System.Drawing.Size(66, 13);
            this.lblGelisSebebi.TabIndex = 1;
            this.lblGelisSebebi.Text = "Geliş Sebebi";
            // 
            // btnAc
            // 
            this.btnAc.BackColor = System.Drawing.Color.Gray;
            this.btnAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAc.ForeColor = System.Drawing.Color.White;
            this.btnAc.Location = new System.Drawing.Point(677, 4);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(54, 32);
            this.btnAc.TabIndex = 2;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = false;
            // 
            // IsEmriItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.pnlGelisSebebi);
            this.Controls.Add(this.pnlAcıklama);
            this.Controls.Add(this.pnlPlaka);
            this.Name = "IsEmriItem";
            this.Size = new System.Drawing.Size(734, 39);
            this.Load += new System.EventHandler(this.IsEmriItem_Load);
            this.pnlPlaka.ResumeLayout(false);
            this.pnlPlaka.PerformLayout();
            this.pnlAcıklama.ResumeLayout(false);
            this.pnlAcıklama.PerformLayout();
            this.pnlGelisSebebi.ResumeLayout(false);
            this.pnlGelisSebebi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlaka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Panel pnlAcıklama;
        private System.Windows.Forms.Label lblAcıklama;
        private System.Windows.Forms.Panel pnlGelisSebebi;
        private System.Windows.Forms.Label lblGelisSebebi;
        private System.Windows.Forms.Button btnAc;
    }
}
