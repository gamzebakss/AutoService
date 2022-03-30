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
    public partial class KullaniciKayitForm : Form
    {
        public KullaniciKayitForm()
        {
            InitializeComponent();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void KullaniciKayitForm_Load(object sender, EventArgs e)
        {

        }

        private void rdbKurumsal_CheckedChanged(object sender, EventArgs e)
        {
          
                grupKurumsalBilgiler.Enabled = ((RadioButton)sender).Checked;
          
        }

        private void rdbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (KullaniciController.Ekle(new Kullanici() { Ad = txtAd.Text, Soyad = txtSoyad.Text, Gsm = txtGsm.Text, Email = txtEmail.Text, Sifre = txtSifre.Text, TicariUnvan = txtTicariU.Text, VergiDairesi = txtVergiD.Text, VergiNo = txtVergiNo.Text, Adres = txtAdres.Text, Durum = true, KullaniciTipi = 1, MusteriTipi = rdbKurumsal.Checked ? (short)1 : (short)0 }))
            {
                MesajKutusu kutu = new MesajKutusu("Başarılı", "Kullanıcı ekleme başarıyla gerçekleşmiştir", MesajIkon.Hata, MesajButton.Tamam);
                kutu.ShowDialog();
                if (kutu._cevap == MesajKutusuCevap.Tamam)
                {
                    this.Dispose();
                    kutu.Dispose();
                }
                else
                {
                    MesajKutusu mskutu = new MesajKutusu("Hata", "Kullanıcı eklenmedi.", MesajIkon.Hata, MesajButton.Tamam);
                    mskutu.ShowDialog();
                    mskutu.Dispose();

                }

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();//Böylede sayfayı tekrar açıp kapattığı için siler textleri sağlıklı bir çözüm değil
            //InitializeComponent();


            foreach (Control control in this.Controls)//Her bir grupbox için çalışa grup döngüsü unutmayalımki grupbox içindeki konroller grupox kontrolleridir dolayısı ile onlara erişmek için grupbox üzerinden derlemek gerekir.
            {
                if (control is GroupBox)
                {
                    foreach (Control ctl in control.Controls)
                    {
                        if (ctl is TextBox || ctl is MaskedTextBox)
                        {
                            ctl.Text = string.Empty;

                        }
                        else if (ctl is RadioButton)
                            ((RadioButton)ctl).Checked = false;
                    }
                }
            }

            //txtAd.Clear();
            //txtSoyad.Clear();
            //txtAdres.Clear();
            //txtEmail.Clear();
            //txtGsm.Clear();
            //txtSifre.Clear();
            //txtTicariU.Clear();
            //txtVergiD.Clear();
            //txtVergiNo.Clear();
            //rdbBireysel.Checked = false;
            //rdbKurumsal.Checked = false;
            

        }
    }
}
