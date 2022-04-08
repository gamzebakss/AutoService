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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

      

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {

            KullaniciKayitForm kayitform = new KullaniciKayitForm();
           
            kayitform.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            BekleyenIsEmirleriniDoldur();
        }

        private void btMusteriListeleme_Click(object sender, EventArgs e)
        {
            KullaniciListele listele = new KullaniciListele();
           
            listele.Show();
        }

       

        private void btnisEmirleri_Click(object sender, EventArgs e)
        {
            IsEmriAracKabulForm isemri = new IsEmriAracKabulForm();
          
            isemri.Show();
        }

       

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm anasayfa = new DashboardForm();
            anasayfa.ShowDialog();
        }


        private void BekleyenIsEmirleriniDoldur()
        {
            List<isEmri> liste = IsEmriControllers.Listele(0);
            foreach (isEmri emir in liste)
            {
                pnlBekleyenIsEmirleri.Controls.Add(new IsEmriItem(emir));
                ////
            }
        }
    }
}
