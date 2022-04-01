using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
