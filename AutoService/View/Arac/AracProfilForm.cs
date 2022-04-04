using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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


            foreach (Fotograf f in _arac.Fotolar)//bellekte pictureboxs oluşturduk 
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(Application.StartupPath + "\\AracFotolari\\" + _arac.id + "\\" + f.Path);
                pic.Width = 150;
                pic.Height = 150;
                pic.Name = "pictureBoxs-" + f.id;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pnlFotolar.Controls.Add(pic);
                pic.DoubleClick += picFoto_DoubleClick;

            }

        }

        private void picFoto_DoubleClick(object sender,EventArgs e)
        {
            //FotoGosterFrom frm = new FotoGosterFrom();
            //frm
        }


        private void grpTemelBilgiler_Enter(object sender, EventArgs e)
        {

        }

        private void ddlKlasorler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlKlasorler.SelectedItem != null)
            {
                if (((DosyaKategori)ddlKlasorler.SelectedItem).id == 0)
                {
                    lstbDosyalar.DataSource = _arac.Dosyalar;
                }
                else
                {
                    lstbDosyalar.DataSource = _arac.Dosyalar.Where(x => x.KategoriID.ToString() == ddlKlasorler.SelectedValue.ToString()).ToList();

                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        
            openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif";
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = openFileDialog1.FileName;
                Dosyayolu.Text = fileName;
            }



        }

        private void grupYukle_Click(object sender, EventArgs e)
        {

            if (grpYukle.Visible == true)
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

            if (((DosyaKategori)ddlKlasorler.SelectedItem).id != 0)
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\AracDosyalari\\" + _arac.id + "\\" + ((DosyaKategori)ddlKlasorler.SelectedItem).Ad))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AracDosyalari\\" + _arac.id + "\\" + ((DosyaKategori)ddlKlasorler.SelectedItem).Ad);
                }
                string dosyaAdi = Tools.TurkceKarakterTemizle(Tools.RandomString(6) + "-" + openFileDialog1.SafeFileName);

                File.Copy(openFileDialog1.FileName, Directory.GetCurrentDirectory() + "\\AracDosyalari\\" + _arac.id + "\\" + ((DosyaKategori)ddlKlasorler.SelectedItem).Ad + "\\" + dosyaAdi);

               if( DosyaControllers.DosyaKaydet(new Dosya
                {
                    Ad=dosyaAdi,
                    AracID=_arac.id,
                    KategoriID=((DosyaKategori)ddlKlasorler.SelectedItem).id,
                    Path=dosyaAdi
                }))
                {
                    MesajKutusu kutu = new MesajKutusu("BİLGİ", "Dosya Yükleme Başarılı Bir Şekilde Gerçekleşmiştir", MesajIkon.Bilgi, MesajButton.Tamam);
                    kutu.ShowDialog();

                    _arac.Dosyalar = DosyaControllers.ListeGetir(_arac.id);
                    lstbDosyalar.DataSource = _arac.Dosyalar.Where(x => x.KategoriID.ToString() == ddlKlasorler.SelectedValue.ToString()).ToList();


                }
            }
            else
            {
                MesajKutusu kutu = new MesajKutusu("Hata", "Lütfen bir klasör seçiniz..", MesajIkon.Hata, MesajButton.Tamam);
                kutu.ShowDialog();
            }


        }
        private void grpYukle_Enter(object sender, EventArgs e)
        {

        }

        private void lstbDosyalar_DoubleClick(object sender, EventArgs e)
        {
           
                Dosya dosya = lstbDosyalar.SelectedItem as Dosya;
                Process.Start(Application.StartupPath + "\\AracDosyalari\\" + _arac.id + "\\" + ((DosyaKategori)ddlKlasorler.SelectedItem).Ad + "\\" + dosya.KategoriID+ dosya.Path);
        
        }

        private void resim1_Click(object sender, EventArgs e)
        {

        }

        private void pnlFotolar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
