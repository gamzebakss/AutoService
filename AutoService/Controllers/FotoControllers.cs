using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
  public static class FotoControllers
    {
        public static List<Fotograf>Getir(int aracID)
        {
            List<Fotograf> list = new List<Fotograf>();

            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select [id],[Path],[AracID],[Ad] From Fotolar where AracID=@aracid", conn);
            cmd.Parameters.AddWithValue("@aracid", aracID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Fotograf { Ad = dr["Ad"].ToString(), id = (int)dr["id"], AracID = (int)dr["AracID"], Path = dr["Path"].ToString() });
            }
            conn.Close();
            return list;
        }

        public static bool FotoKaydet(Fotograf fotograf)
        {

            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Insert into Fotolar (Ad,Path,AracID) values (@Ad,@Path,@AracID)", conn);
            cmd.Parameters.AddWithValue("@Ad", fotograf.Ad);
            cmd.Parameters.AddWithValue("@Path",fotograf.Path);
            cmd.Parameters.AddWithValue("@AracID",fotograf.AracID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public static List<Fotograf> ListeGetir(int aracID)
        {
            List<Fotograf> liste = new List<Fotograf>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("select  id,Ad,Path,AracID from Fotolar Where AracID=@AracID  ", conn);
            cmd.Parameters.AddWithValue("@AracID", aracID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                liste.Add(new Fotograf { AracID = aracID, Ad = dr["Ad"].ToString(), id = (int)dr["id"], Path = dr["Path"].ToString() });
            }
            conn.Close();
            return liste;
        }


       public static bool Sil(Fotograf foto)
        {
            try
            {
                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("Delete from Fotograflar where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", foto.id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                File.Delete(Directory.GetCurrentDirectory() + "\\Fotograflar\\" + foto.AracID + "\\" + foto.Path);


                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
