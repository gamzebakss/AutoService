using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.View.Shared
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void servisİşlemTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {

            KullaniciKayitForm kayitform = new KullaniciKayitForm();
            kayitform.Show();
        }
    }
}
