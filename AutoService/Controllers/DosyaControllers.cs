using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService

{
    public static class DosyaControllers
    {
        public static List<Dosya> ListeGetir(int aracID)
        {
            List<Dosya> liste = new List<Dosya>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select id,Ad,Path,KategoriID,AracID From Dosyalar where AracID=@aracid", conn);
            cmd.Parameters.AddWithValue("@aracid", aracID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                liste.Add(new Dosya { AracID = aracID, Ad = dr["Ad"].ToString(), id = (int)dr["id"], KategoriID = (int)dr["KategoriID"], Path = dr["Path"].ToString() });
            }
            conn.Close();
            return liste;
        }

        public static List<Dosya> ListeGetir(int aracID,int KategoriID)
        {
            List<Dosya> liste = new List<Dosya>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select id,Ad,Path,KategoriID,AracID From Dosyalar where AracID=@aracid and KategoriID=@kategoriid", conn);
            cmd.Parameters.AddWithValue("@aracid", aracID);
            cmd.Parameters.AddWithValue("@kategoriid", KategoriID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())

            {
                liste.Add(new Dosya { AracID = aracID, Ad = dr["Ad"].ToString(), id = (int)dr["id"], KategoriID = (int)dr["KategoriID"], Path = dr["Path"].ToString() });
            }

            conn.Close();
            return liste;
        }
    }
}
