using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public static class KullaniciController

    {
        private static object md5Sifre;
        public static Kullanici Login(string email, string sifre)
        {
            string md5Sifre = Tools.MD5Uret(Properties.Settings.Default.SecretKey + sifre);

            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * From Kullanicilar Where Email=@email and UPPER(Sifre)=@sifre", conn);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sifre", md5Sifre);
            conn.Open();


            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            Kullanici kul;
            if (dr.HasRows)
            {
                kul = new Kullanici();
                kul.Ad = dr["Ad"].ToString();
                kul.Adres = dr["Adres"].ToString();
                kul.Durum = bool.Parse(dr["Durum"].ToString());
                kul.Email = dr["Email"].ToString();
                kul.Gsm = dr["Gsm"].ToString();
                kul.id = (int)dr["id"];
                kul.KullaniciTipi = (short)dr["KullaniciTipi"];
                kul.MusteriTipi = (short)dr["MusteriTipi"];
                kul.OlusturmaTarihi = (DateTime)dr["OlusturmaTarihi"];
                kul.Sifre = dr["Sifre"].ToString();
                kul.Soyad = dr["Soyad"].ToString();
                kul.TicariUnvan = dr["TicariUnvan"].ToString();
                kul.VergiDairesi = dr["VergiDairesi"].ToString();
                kul.VergiNo = dr["VergiNo"].ToString();

            }
            else
            {
                kul = new Kullanici { id = 0 };
            }
            dr.Close();
            conn.Close();

            return kul;
        }

        public static bool SifreSifirla(string email)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("SELECT count(*) from Kullanicilar where Email=@email", conn);
            cmd.Parameters.AddWithValue("@email", email);
            conn.Open();
            int sonuc = (int)cmd.ExecuteScalar();
            conn.Close();
            if (sonuc == 0)
            {
                MesajKutusu kutu = new MesajKutusu("HATA", "Böyle bir email adresi bulunamadı", MesajIkon.Hata, MesajButton.Tamam);
                kutu.ShowDialog();

            }
            else
            {
                Random rnd = new Random();
                int yeniSifre = rnd.Next(1000, 9999);

                string md5Sifre = Tools.MD5Uret(Properties.Settings.Default.SecretKey + yeniSifre);

                cmd = new SqlCommand("UPDATE Kullanicilar sET Sifre=@sifre WHERE Email=@email", conn);
                cmd.Parameters.AddWithValue("@sifre", md5Sifre);
                cmd.Parameters.AddWithValue("@email", email);
                conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();

                Email.MailGonder(email, "Yeni Şifre ", "Yeni Şifreniz Hakkında.Yeni Şifreniz:" + yeniSifre);


                //ExecuteReader datebase. 1 kolonunu ve 1 satırını gönderir sadece 

            }
            return false;
        }

        public static bool Ekle(Kullanici kul)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Insert into Kullanicilar values (@ad,@soyad,@gsm,@email,@sifre,@ticariunvan,@vergidairesi,@vergino,@adres,@musteritip,@kullanicitip,@durum,getdate(),@profilfoto)", conn);

            cmd.Parameters.AddWithValue("@ad", kul.Ad);
            cmd.Parameters.AddWithValue("@soyad", kul.Soyad);
            cmd.Parameters.AddWithValue("@gsm", kul.Gsm);
            cmd.Parameters.AddWithValue("@email", kul.Email);
            cmd.Parameters.AddWithValue("@sifre", Tools.MD5Uret(Properties.Settings.Default.SecretKey + kul.Sifre));//Şifre olduğu gibi gelmesin diye
            cmd.Parameters.AddWithValue("@ticariunvan", kul.TicariUnvan);
            cmd.Parameters.AddWithValue("@vergidairesi", kul.VergiDairesi);
            cmd.Parameters.AddWithValue("@vergino", kul.VergiNo);
            cmd.Parameters.AddWithValue("@adres", kul.Adres);
            cmd.Parameters.AddWithValue("@musteritip", kul.MusteriTipi);
            cmd.Parameters.AddWithValue("@kullanicitip", kul.KullaniciTipi);
            cmd.Parameters.AddWithValue("@durum", kul.Durum);
            cmd.Parameters.AddWithValue("@profilfoto", DBNull.Value);


            conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            conn.Close();

            if (sayi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        public static Kullanici BilgileriGetir(int KullaniciID)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * From Kullanicilar where id=" + KullaniciID, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();


            return new Kullanici()
            {
                id = (int)dr["id"],
                Ad = dr["Ad"].ToString(),
                Soyad = dr["Soyad"].ToString(),
                Gsm = dr["Gsm"].ToString(),
                Email = dr["Email"].ToString(),
                Sifre = dr["Sifre"].ToString(),
                TicariUnvan = dr["TicariUnvan"].ToString(),
                VergiDairesi = dr["VergiDairesi"].ToString(),
                VergiNo = dr["VergiNo"].ToString(),
                Adres=dr["Adres"].ToString(),
                MusteriTipi = (short)dr["MusteriTipi"],
                KullaniciTipi = (short)dr["KullaniciTipi"],
                Durum = (bool)dr["Durum"],
                OlusturmaTarihi = (DateTime)dr["OlusturmaTarihi"], 
                ProfilFoto=dr["ProfilFoto"].ToString()

            };
        }

       public static bool ProfilFotoGuncelle(string dosyaAdi,int kullaniciID)
        {
            try
            {

                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("Update Kullanicilar set ProfilFoto=@profilfoto where id=@id ", conn);
                cmd.Parameters.AddWithValue("@profilfoto", dosyaAdi);
                cmd.Parameters.AddWithValue("@id", kullaniciID);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                conn.Close();

                return true;
            }
            catch 
            {
                return false;
            }

        }
    }
}
