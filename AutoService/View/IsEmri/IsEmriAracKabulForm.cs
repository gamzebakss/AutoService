using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
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
    public partial class IsEmriAracKabulForm : Form
    {
        public IsEmriAracKabulForm()
        {
            _araclar = AracControllers.TumunuGetir();
            InitializeComponent();

            cmblistGelisSebebi.DataSource = IsEmriTuruControllers.Listele();
            cmblistGelisSebebi.ValueMember = "id";
            cmblistGelisSebebi.DisplayMember = "Ad";

        }

        public List<Arac> _araclar { get; set; }

        public Arac _seciliArac { get; set; }

        private void IsEmriAracKabulForm_Load(object sender, EventArgs e)
        {

        }

        private void txtAracPlakasi_TextChanged(object sender, EventArgs e)
        {
            //Çözüm4---------------------------------------------------
            _seciliArac = _araclar.Find(a => a.Plaka.ToUpper() == txtAracPlakasi.Text.ToUpper());
            if (_seciliArac != null)
            {
                lblModel.Text = _seciliArac.Model.Ad;
                lblPlaka.Text = _seciliArac.Plaka;
                lblRenk.Text = _seciliArac.Renk;
                lblSasiNo.Text = _seciliArac.SasiNo;
                lblYil.Text = _seciliArac.Yil.ToString();


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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmblistGelisSebebi.SelectedValue.ToString() != "0")
            {
                if (IsEmriControllers.Ekle(new isEmri { Aciklama = txtMusteriAciklamasi.Text, Durum = 0, IsEmriTuru = cmblistGelisSebebi.SelectedItem as IsEmriTuru, TeslimAlan = txtTeslimAlan.Text, TeslimEden = txtTeslimAlan.Text,Arac= _seciliArac}))
                {
                    PdfOlustur();
                    MesajKutusu kutu = new MesajKutusu("İşlem Başarılı", "Araç Kabul işlemi kaydedildi", MesajIkon.Bilgi, MesajButton.Tamam);
                    kutu.ShowDialog();
                    if (kutu._cevap == MesajKutusuCevap.Evet)
                    {
                        Temizle();
                    }
                    else
                        this.Dispose();
                }
                else
                {
                    MesajKutusu kutu = new MesajKutusu("İşlem Başarısız", "Araç Kabul işlemi kaydedilmedi", MesajIkon.Hata, MesajButton.Tamam);
                    kutu.ShowDialog();
                }
            }
        }
        private void Temizle()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
            cmblistGelisSebebi.SelectedValue = 0;
        }
        private void PdfOlustur()
        {
            PdfDocument pdf = PdfReader.Open("sablon.pdf", PdfDocumentOpenMode.Modify);
            pdf.Info.Title = "Araç Kabul Formu";

            PdfPage sayfa = pdf.Pages[0];

            XGraphics gfx = XGraphics.FromPdfPage(sayfa);

            XFont h1 = new XFont("Verdana", 25, XFontStyle.Bold);
            XFont h3 = new XFont("Verdana", 15, XFontStyle.Bold);
            XFont h3u = new XFont("Verdana", 15, XFontStyle.Underline);
            XBrush KirmiziFirca = XBrushes.Red;
            XBrush Siyah = XBrushes.Black;

            //Sayfamızın ortalanmış başlığı, 

            //Tarihi sol üst köşeye yazdık.
            gfx.DrawString(DateTime.Now.ToShortDateString(), h3, Siyah, sayfa.Width - 100, 20);

            int offsetX = 100;
            int offsetY = 135;

            gfx.DrawString(_seciliArac.Plaka, h3, KirmiziFirca, offsetX + 150, offsetY);

            offsetY += 30;

            gfx.DrawString(_seciliArac.Model.Ad, h3, KirmiziFirca, offsetX + 150, offsetY);

            offsetY += 30;

            gfx.DrawString((cmblistGelisSebebi.SelectedItem as IsEmriTuru).Ad, h3, KirmiziFirca, offsetX + 150, offsetY);

            offsetY += 30;

            gfx.DrawString(txtMusteriAciklamasi.Text, h3, KirmiziFirca, offsetX + 150, offsetY);

            gfx.DrawString(txtTeslimAlan.Text, h3, KirmiziFirca, offsetX - 20, offsetY + 210);

            gfx.DrawString(txtTeslimeden.Text, h3, KirmiziFirca, offsetX + 280, offsetY + 210);

            string dosyaAdi = Tools.TurkceKarakterTemizle(_seciliArac.Plaka) + "-" + Tools.RandomString(10) + ".pdf";

            pdf.Save(Directory.GetCurrentDirectory() + "\\PDFs\\" + dosyaAdi);//bin klasörü altında PDFs klasörü oluşturulacak ordan çekicek....
            Process.Start(Directory.GetCurrentDirectory() + "\\PDFs\\" +dosyaAdi);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            PdfOlustur();
        }
    }
}
