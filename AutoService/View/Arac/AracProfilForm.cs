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
    public partial class AracProfilForm : Form
    {
        public Arac _arac { get; set; }
        public AracProfilForm(int aracID)
        {
           _arac = AracControllers.Getir(aracID);

            InitializeComponent();

         

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AracProfilForm_Load(object sender, EventArgs e)
        {
            lblModel.Text = _arac.Model.Ad;
            lblPlaka.Text = _arac.Plaka; ;
            lblRenk.Text = _arac.Renk;
            lblSasiNo.Text = _arac.SasiNo;
            lblYil.Text = _arac.Yil.ToString();

            List<DosyaKategori> dosyaKategoris = DosyaKategoriContollers.List();
            dosyaKategoris.Add(new DosyaKategori { id = 0, Ad = "Hepsi" });
            ddlKlasorler.DataSource = dosyaKategoris;

            ddlKlasorler.ValueMember = "id";
            ddlKlasorler.DisplayMember = "Ad";
            ddlKlasorler.SelectedValue = 0;
            lstbDosyalar.DataSource = _arac.Dosyalar;
            lstbDosyalar.ValueMember = "id";
            lstbDosyalar.DisplayMember = "Ad";

        }

        private void grpTemelBilgiler_Enter(object sender, EventArgs e)
        {

        }

        private void ddlKlasorler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlKlasorler.SelectedItem!=null)
            {
                if (((DosyaKategori)ddlKlasorler.SelectedItem).id==0)
                {
                    lstbDosyalar.DataSource = _arac.Dosyalar;
                }
                else
                {
                    lstbDosyalar.DataSource = _arac.Dosyalar.Where(x => x.KategoriID.ToString() ==ddlKlasorler.SelectedValue.ToString()).ToList();

                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void grupYukle_Click(object sender, EventArgs e)
        {

            if (grpYukle.Visible==true)
            {
                grpYukle.Visible = false;
                grpDosyalar.Location = new Point
                {
                    X = grpDosyalar.Location.X,
                    Y = grpDosyalar.Location.Y - 96
                };
            }
            else
            {
                grpDosyalar.Location = new Point
                {
                    X = grpDosyalar.Location.X,
                    Y = grpDosyalar.Location.Y + 96
                };
                grpYukle.Visible = true;
            }

          
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {

        }

        private void grpYukle_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
