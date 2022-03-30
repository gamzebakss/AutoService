using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
   internal class AracModelControllers
    {
        public static List<AracModel>Getir(int markaID)
        {
            List<AracModel> list = new List<AracModel>();
            SqlConnection conn = db.conn();
            SqlCommand cmd= new SqlCommand("Select id,Ad from Modeller WHERE MarkaID=@markaid", conn);
            cmd.Parameters.AddWithValue("@markaid", markaID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new AracModel { id = (int)dr["id"], Ad = dr["Ad"].ToString()});
            }
            conn.Close();
            return list;
        }
    }
}
