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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KullaniciAdi != string.Empty)//
            {
                if (Properties.Settings.Default.BeniHatirla == true)
                {
                    txtKullanici.Text = Properties.Settings.Default.KullaniciAdi;
                    txtSifre.Text = Properties.Settings.Default.Sifre;
                    chkBeniHatirla.Checked = true;
                }
                else
                {
                    chkBeniHatirla.Checked = false;
                }
            }

            //string kullaniciadi = Properties.Settings.Default.KullaniciAdi;

        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            Kullanici kul = KullaniciController.Login(txtKullanici.Text, txtSifre.Text);

            if (kul.id != 0)//Beni hatırlaması için yazdığım kod
            {
                if (chkBeniHatirla.Checked)
                {
                    Properties.Settings.Default.KullaniciAdi = txtKullanici.Text;
                    Properties.Settings.Default.Sifre = txtSifre.Text;
                    Properties.Settings.Default.BeniHatirla = true;
                    Properties.Settings.Default.Save();

                }


            }
            else
            {

                MesajKutusu kutu = new MesajKutusu("HATA", "Kullanıcı adı ve şifre yanlış", MesajIkon.Hata, MesajButton.Tamam);
                kutu.ShowDialog();
                //if (kutu._cevap==MesajKutusuCevap.Tamam)//Silmk istedğinizden eminmisiniz kısmına böyle bişey yapıcaz
                //{
                //    MessageBox.Show("Tamam Cevabı verdiniz");
                //}
                //else if(kutu._cevap == MesajKutusuCevap.Evet)
                //{
                //    MessageBox.Show("Evet Cevabı verdiniz");
                //}

                //MessageBox.Show("Giriş Hatası");
            }
        }

        private void btnSifreUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum frm = new SifremiUnuttum();
            frm.ShowDialog();
        }
    }
}
