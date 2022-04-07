using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
                if (IsEmriControllers.Ekle(new isEmri { Aciklama = txtMusteriAciklamasi.Text, Durum = 0, IsEmriTuru = cmblistGelisSebebi.SelectedItem as IsEmriTuru, TeslimAlan = txtTeslimAlan.Text, TeslimEden = txtTeslimAlan.Text, AracID =_seciliArac.id}))
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
            PdfDocument pdf= new PdfDocument();
            pdf.Info.Title = "Araç Kabul Formu";


            PdfPage sayfa = pdf.AddPage();

            sayfa.Orientation = PdfSharp.PageOrientation.Landscape;//Sayfanın yatay oluşunu ayarlıyoruz.
            sayfa.Size = PdfSharp.PageSize.A5;//sayfanın a5 formatında açılmasını sağlıyoruz.


            XGraphics grafik = XGraphics.FromPdfPage(sayfa);

            XFont h1 = new XFont("Verdana", 25, XFontStyle.Bold);
            XFont h3 = new XFont("Verdana", 15, XFontStyle.Bold);
            XBrush kirmizifirca = XBrushes.Red;
            XBrush Siyahfirca = XBrushes.Black;

            //Sayfamızın ortalanmış başlığı
            grafik.DrawString("Araç Kabul Formu", h1, Siyahfirca, new XRect(0, 0, sayfa.Width, sayfa.Height), XStringFormat.TopCenter);

            //Tarihi sol üst köşeye yazdık
            grafik.DrawString(DateTime.Now.ToShortDateString(), h3, Siyahfirca, new XRect(0, 0, sayfa.Width, sayfa.Height), XStringFormat.TopCenter);

            int offsetX = 100;
            int offsetY = 100;


            
            grafik.DrawString("Araç Plakası : ", h3, Siyahfirca, offsetX, offsetY);
            grafik.DrawString(_seciliArac.Plaka, h3, kirmizifirca, offsetX + 120, offsetY);


            offsetY += 20;

            grafik.DrawString("Araç Modeli : ", h3, Siyahfirca, offsetX, offsetY);
            grafik.DrawString(_seciliArac.Model.Ad, h3, kirmizifirca, offsetX + 120,offsetY);

            offsetY += 20;

            grafik.DrawString("Açıklama : ", h3, Siyahfirca, offsetX, offsetY);
            grafik.DrawString(txtMusteriAciklamasi.Text, h3, kirmizifirca, offsetX + 120, offsetY);

            offsetY += 20;

            grafik.DrawString("Geliş Sebebi : ", h3, Siyahfirca, offsetX, offsetY);
            grafik.DrawString((cmblistGelisSebebi.SelectedItem as IsEmriTuru).Ad, h3, kirmizifirca, offsetX + 120, offsetY);


            offsetY += 50;

            grafik.DrawString("Teslim Eden : ", h3, Siyahfirca, offsetX-20, offsetY);
            grafik.DrawString(txtTeslimeden.Text, h3, kirmizifirca, offsetX - 20, offsetY+20);


            grafik.DrawString("Teslim Alan : ", h3, Siyahfirca, offsetX+240, offsetY);
            grafik.DrawString(txtTeslimAlan.Text, h3, kirmizifirca, offsetX + 240, offsetY+20);









            string dosyaAdi = Tools.TurkceKarakterTemizle(_seciliArac.Plaka) + "-" + Tools.RandomString(10) + ".pdf";
            pdf.Save(Directory.GetCurrentDirectory() + "\\PDFs\\" + dosyaAdi);
            Process.Start(Directory.GetCurrentDirectory() + "\\PDFs\\" + dosyaAdi);

            pdf.Save(Directory.GetCurrentDirectory() + "\\Hello.pdf");

        

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
       //PdfOlustur();
        }
    }
}
