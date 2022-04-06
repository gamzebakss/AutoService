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
            _araclar = AracControllers.TumunuGetir();
            InitializeComponent();
        }

        public List<Arac> _araclar { get; set; }
        private void IsEmriAracKabulForm_Load(object sender, EventArgs e)
        {

        }

        private void txtAracPlakasi_TextChanged(object sender, EventArgs e)
        {
            //Çözüm4---------------------------------------------------
            Arac arac = _araclar.Find(a => a.Plaka.ToUpper() == txtAracPlakasi.Text.ToUpper());
            if (arac != null)
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


            //Aşağıda yaptığımız çözümler veritabınana sadece bir kez bağlansın diye tekrar tekrar bağlanmasını önlemek için yaptık..

            //Çözüm3---------------------------------------------------
            //try
            //{
            //    Arac arac = _araclar.Where(a => a.Plaka.ToUpper() == txtAracPlakasi.Text.ToUpper()).ToList().Single();

            //    lblModel.Text = arac.Model.Ad;
            //    lblPlaka.Text = arac.Plaka;
            //    lblRenk.Text = arac.Renk;
            //    lblSasiNo.Text = arac.SasiNo;
            //    lblYil.Text = arac.Yil.ToString();
            //}
            //catch
            //{ }

            //Çözüm2---------------------------------------------------------
            //List<Arac> liste = _araclar.Where(a => a.Plaka.ToUpper() == txtAracPlakasi.Text.ToUpper()).ToList();

            //if (liste.Count>0)
            //{
            //    lblModel.Text = liste[0].Model.Ad;
            //    lblPlaka.Text = liste[0].Plaka;
            //    lblRenk.Text = liste[0].Renk;
            //    lblSasiNo.Text = liste[0].SasiNo;
            //    lblYil.Text = liste[0].Yil.ToString();
            //}


            //Burada veri tabınan tekrar tekrar bağlanıyor----------------------------------------------
            //Arac arac=AracControllers.Getir(txtAracPlakasi.Text);
            //    if (arac.id!=0)
            //    {
            //        lblModel.Text = arac.Model.Ad;
            //        lblPlaka.Text = arac.Plaka;
            //        lblRenk.Text = arac.Renk;
            //        lblSasiNo.Text = arac.SasiNo;
            //        lblYil.Text = arac.Yil.ToString();
            //    }
            //    else
            //    {
            //        lblModel.Text = "";
            //        lblPlaka.Text = "";
            //        lblRenk.Text = "";
            //        lblSasiNo.Text = "";
            //        lblYil.Text = "";

            //    }
        }
    }
}
