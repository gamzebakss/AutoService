using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
            SqlCommand cmd = new SqlCommand("Select id,Ad,Path,KategoriID,AracID,(Select Ad from DosyalarKategoriler where id=KategoriID) as KategoriAdi from Dosyalar where AracID=@aracid", conn);
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
        public static bool DosyaKaydet(Dosya dosya)
        {
            try
            {
                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("Insert into Dosyalar(Ad,Path,KategoriID,AracID)values(@ad,@path,@kategoriid,@aracid)", conn);
                cmd.Parameters.AddWithValue("@ad", dosya.Ad);
                cmd.Parameters.AddWithValue("@path", dosya.Path);
                cmd.Parameters.AddWithValue("@kategoriid", dosya.KategoriID);
                cmd.Parameters.AddWithValue("@aracid", dosya.AracID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();
                return true;

            }
            catch 
            {

                return false;
            } 
            
        }
      public static bool DosyaSil(Dosya dosya)
        {
            try
            {
                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("Delete from Dosyalar where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", dosya.id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                File.Delete(Directory.GetCurrentDirectory() + "\\AracDosyalar\\" + dosya.AracID + "\\" + dosya.KategoriAdi + dosya.Path);
                return true;
            }
            catch 
            {

                return false;
            }
            
        }
    }
}
