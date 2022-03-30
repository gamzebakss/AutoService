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
            SqlCommand cmd= new SqlCommand("Select a.*,m.Ad as Model from Araclar a,Modeller m where   m.id=a.ModelID and KullaniciID=@kullaniciid", conn);
            cmd.Parameters.AddWithValue("@kullaniciid",KullaniciID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new Arac { id = (int)dr["id"], Plaka = dr["Plaka"].ToString(), ModelID = (int)dr["ModelID"], SasiNo = dr["SasiNo"].ToString(), Yil = (int)dr["Yil"], Renk = dr["Renk"].ToString(), KullaniciID = (int)dr["KullaniciId"] });
            }

            conn.Close();
            return list;

        }
    }
}
