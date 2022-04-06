using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
        public static class AracControllers
    {
        public static bool Ekle(Arac arac)
        {
            try
            {
                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("Insert into Araclar values (@plaka,@Modelid,@sasino,@yil,@renk,@kullaniciid)", conn);

                cmd.Parameters.AddWithValue("@plaka", arac.Plaka);
                cmd.Parameters.AddWithValue("@Modelid", arac.ModelID);
                cmd.Parameters.AddWithValue("@sasino", arac.SasiNo);
                cmd.Parameters.AddWithValue("@yil", arac.Yil);
                cmd.Parameters.AddWithValue("@renk", arac.Renk);
                cmd.Parameters.AddWithValue("@kullaniciid", arac.KullaniciID);


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

        public static List<Arac>Listele(int KullaniciID)
        {
            List<Arac> list = new List<Arac>();

             SqlConnection conn = db.conn();
            SqlCommand cmd= new SqlCommand("Select * from Araclar where KullaniciID=@kullaniciid", conn);
            cmd.Parameters.AddWithValue("@kullaniciid",KullaniciID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new Arac { id = (int)dr["id"], Plaka = dr["Plaka"].ToString(), ModelID = (int)dr["ModelID"], SasiNo = dr["SasiNo"].ToString(), Yil = (int)dr["Yil"], Renk = dr["Renk"].ToString(), KullaniciID = (int)dr["KullaniciId"], Model=AracModelControllers.GetirByAracID((int)dr["id"])});
            }

            conn.Close();
            return list;

        }
        public static Arac  Getir(int aracID)//Burdan AracModelController yazdığımız GetirByAracID yaptığımız kodları çağırıyoruz... 
        {
            Arac arac = new Arac();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select [id],[Plaka],[ModelID],[SasiNo],[Yil],[Renk],[KullaniciID] From Araclar where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", aracID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            arac.Renk = dr["Renk"].ToString();
            arac.KullaniciID = (int)dr["KullaniciID"];
            arac.Plaka = dr["Plaka"].ToString();
            arac.ModelID = (int)dr["ModelID"];
            arac.SasiNo = dr["SasiNo"].ToString();
            arac.Yil = (int)dr["Yil"];
            arac.id = (int)dr["id"];
            arac.Dosyalar = DosyaControllers.ListeGetir(aracID);
            arac.Model =AracModelControllers.GetirByAracID(aracID);
            arac.Fotolar =FotoControllers.Getir(aracID);
           
            conn.Close();


            return arac;
        
        }


        public static Arac Getir(string Plaka)
        {
            Arac arac = new Arac();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select [id],[Plaka],[ModelID],[SasiNo],[Yil],[Renk],[KullaniciID] From Araclar where Plaka LIKE @plaka", conn);
            cmd.Parameters.AddWithValue("@plaka", Plaka);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                arac.Renk = dr["Renk"].ToString();
                arac.KullaniciID = (int)dr["KullaniciID"];
                arac.Plaka = dr["Plaka"].ToString();
                arac.ModelID = (int)dr["ModelID"];
                arac.SasiNo = dr["SasiNo"].ToString();
                arac.Yil = (int)dr["Yil"];
                arac.id = (int)dr["id"];
                arac.Dosyalar = DosyaControllers.ListeGetir((int)dr["id"]);
                arac.Model = AracModelControllers.GetirByAracID((int)dr["id"]);
                arac.Fotolar = FotoControllers.Getir((int)dr["id"]);
            }
            else
            {
                arac.id = 0;
            }
            conn.Close();


            return arac;

        }
        public static List<Arac> TumunuGetir()
        {
            Arac arac = new Arac();
            List<Arac> Liste = new List<Arac>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select [id],[Plaka],[ModelID],[SasiNo],[Yil],[Renk],[KullaniciID] from Araclar", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            while(dr.Read())
            {
                arac.Renk = dr["Renk"].ToString();
                arac.KullaniciID = (int)dr["KullaniciID"];
                arac.Plaka = dr["Plaka"].ToString();
                arac.ModelID = (int)dr["ModelID"];
                arac.SasiNo = dr["SasiNo"].ToString();
                arac.Yil = (int)dr["Yil"];
                arac.id = (int)dr["id"];
                arac.Dosyalar = DosyaControllers.ListeGetir((int)dr["id"]);
                arac.Model = AracModelControllers.GetirByAracID((int)dr["id"]);
                arac.Fotolar = FotoControllers.Getir((int)dr["id"]);
                Liste.Add(arac);
            }
           
            conn.Close();

            return Liste;
        }
    }
}
