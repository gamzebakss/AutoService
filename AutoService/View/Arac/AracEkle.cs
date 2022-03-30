using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{


    public partial class AracEkle : Form
    {
        public int _kullaniciID { get; set; }
        public AracEkle(int KullaniciID)
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoServiceDataSet2.Markalar' table. You can move, or remove it, as needed.
            this.markalarTableAdapter.Fill(this.autoServiceDataSet2.Markalar);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedValue != null)
            {
                cmbModel.DataSource = AracModelControllers.Getir((int)cmbMarka.SelectedValue);
                cmbModel.ValueMember = "id";
                cmbModel.DisplayMember = "Ad";

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtYil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRenk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSasiNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            if (AracControllers.Ekle(new Arac { KullaniciID = _kullaniciID, ModelID = (int)cmbModel.SelectedValue, Plaka = txtPlaka.Text, Renk = txtRenk.Text, SasiNo = txtSasiNo.Text, Yil = int.Parse(txtYil.Text) }))
            {
                MesajKutusu kutu = new MesajKutusu("Başarılı", "Araç ekleme başarıyla gerçekleşmiştir", MesajIkon.Uyari, MesajButton.Tamam);
                kutu.ShowDialog();
            }
            else
            {
                MesajKutusu mskutu = new MesajKutusu("Hata", "Araç eklenemedi.", MesajIkon.Hata, MesajButton.Tamam);
                mskutu.ShowDialog();
                mskutu.Dispose();
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
