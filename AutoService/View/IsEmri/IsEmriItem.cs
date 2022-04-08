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
    public partial class IsEmriItem : UserControl
    {
      


        public IsEmriItem(isEmri isEmri)
        {
            InitializeComponent();

            lblAcıklama.Text = isEmri.Aciklama;
            lblGelisSebebi.Text = isEmri.IsEmriTuru.Ad;
            lblPlaka.Text = isEmri.Arac.Plaka;



        }

        private void IsEmriItem_Load(object sender, EventArgs e)
        {

        }

        private void pnlAcıklama_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pnlGelisSebebi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
