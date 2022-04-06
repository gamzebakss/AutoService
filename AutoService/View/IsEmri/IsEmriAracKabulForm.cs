using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class IsEmriAracKabulForm : Form
    {
        public IsEmriAracKabulForm()
        {
            InitializeComponent();
        }

        private void IsEmriAracKabulForm_Load(object sender, EventArgs e)
        {

        }

        private void txtAracPlakasi_TextChanged(object sender, EventArgs e)
        {
        Arac arac=AracControllers.Getir(txtAracPlakasi.Text);
            if (arac.id!=0)
            {
                lblModel.Text = arac.Model.Ad;
                lblPlaka.Text = arac.Plaka;
                lblRenk.Text = arac.Renk;
                lblSasiNo.Text = arac.SasiNo;
                lblYil.Text = arac.Yil.ToString();
            }
            else
            {
                lblModel.Text = "";
                lblPlaka.Text = "";
                lblRenk.Text = "";
                lblSasiNo.Text = "";
                lblYil.Text = "";

            }
        }
    }
}
