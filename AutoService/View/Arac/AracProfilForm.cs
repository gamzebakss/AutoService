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
            AracBilgileriniDoldur();


        }

        private void AracBilgileriniDoldur()
        {
            lblModel.Text = _arac.Model.Ad;
            lblPlaka.Text = _arac.Plaka; ;
            lblRenk.Text = _arac.Renk;
            lblSasiNo.Text = _arac.SasiNo;
            lblYil.Text = _arac.Yil.ToString();

            DosyalariDoldur();
        }
        private void DosyalariDoldur()
        {

            List<DosyaKategori> dosyaKategoris = DosyaKategoriContollers.List();
            dosyaKategoris.Add(new DosyaKategori { id = 0, Ad = "Hepsi" });
            ddlKlasorler.DataSource = dosyaKategoris;

            ddlKlasorler.ValueMember = "id";
            ddlKlasorler.DisplayMember = "Ad";
            ddlKlasorler.SelectedValue = 0;
            lstbDosyalar.DataSource = _arac.Dosyalar;
            lstbDosyalar.ValueMember = "id";
            lstbDosyalar.DisplayMember = "Ad";

            FotolariDoldur();
        }

        private void FotolariDoldur()
        {
            pnlFotolar.Controls.Clear();

            foreach (Fotograf f in _arac.Fotolar)//bellekte pictureboxs oluşturduk 
            {
                FlowLayoutPanel pnlPicture = new FlowLayoutPanel();
                pnlPicture.FlowDirection = FlowDirection.TopDown;
                pnlPicture.Width = 150;
                pnlPicture.Height = 180;



                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(Application.StartupPath + "\\Fotograflar\\" + _arac.id + "\\" + f.Path);
                pic.Width = 160;
                pic.Height = 160;
                pic.Name = "pictureBoxs-" + f.id;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.DoubleClick += picDouble;
                pnlPicture.Controls.Add(pic);

                Button btn = new Button();
                btn.Text = "Sil";
                btn.Tag = f;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.Red;
                btn.Click += Btn_Click;
               


                pnlFotolar.Controls.Add(pic);

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            FotoControllers.Sil((((sender as Button).Tag) as Fotograf));
            _arac.Fotolar = FotoControllers.Getir(_arac.id);
            FotolariDoldur();
        }
        private void picDouble(object sender, EventArgs e)
        {
            FotolariGoster frm = new FotolariGoster((sender as PictureBox).Image);
            frm.ShowDialog();
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

                if (DosyaControllers.DosyaKaydet(new Dosya
                {
                    Ad = dosyaAdi,
                    AracID = _arac.id,
                    KategoriID = ((DosyaKategori)ddlKlasorler.SelectedItem).id,
                    Path = dosyaAdi
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

        private void lstbDosyalar_DoubleClick(object sender, EventArgs e)
        {

            Dosya dosya = lstbDosyalar.SelectedItem as Dosya;
            Process.Start(Application.StartupPath + "\\AracDosyalari\\" + _arac.id + "\\" + ((DosyaKategori)ddlKlasorler.SelectedItem).Ad + "\\" + dosya.KategoriID + dosya.Path);

        }





        private void AracProfilForm_Load(object sender, EventArgs e)
        {

        }

        private void resim1_Click(object sender, EventArgs e)
        {



        }

        private void btnresimGozat_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();

        }

        private void btnresimYukle_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Fotograflar\\" + _arac.id))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Fotograflar\\" + _arac.id);
            }

            string dosyaAdi = Tools.TurkceKarakterTemizle(Tools.RandomString(6) + "-" + openFileDialog2.SafeFileName);

            File.Copy(openFileDialog2.FileName, Directory.GetCurrentDirectory() + "\\Fotograflar\\" + _arac.id + "\\" + dosyaAdi);

            if (FotoControllers.FotoKaydet(new Fotograf
            {
                Ad = dosyaAdi,
                AracID = _arac.id,
                Path = dosyaAdi
            }))
            {
                MesajKutusu kutu = new MesajKutusu("Başarılı", "Dosya yükleme başarıyla tamamlanmıştır", MesajIkon.Uyari, MesajButton.Tamam);
                kutu.ShowDialog();

                _arac.Fotolar = FotoControllers.ListeGetir(_arac.id);
                FotolariDoldur();
            }
            else
            {
                MesajKutusu kutu = new MesajKutusu("hata", "Lütfen bir klasör seciniz", MesajIkon.Uyari, MesajButton.Tamam);
                kutu.ShowDialog();
            }

        }

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {
            Dosya dosya = lstbDosyalar.SelectedItem as Dosya;
            if (dosya!=null)
            {
                DosyaControllers.DosyaSil(dosya);
                _arac.Dosyalar = DosyaControllers.ListeGetir(_arac.id);
                DosyalariDoldur();
            }

        }

        private void lstbDosyalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstbDosyalar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnresimSil_Click(object sender, EventArgs e)
        {

        }
    }
}

