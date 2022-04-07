using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public static class IsEmriTuruControllers
    {
        static public List<IsEmriTuru> Listele()
        {
            List<IsEmriTuru> list = new List<IsEmriTuru>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select id,Ad From IsEmirleriTurleri order by Ad asc ", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new IsEmriTuru { id = (int)dr["id"], Ad = dr["Ad"].ToString() });
            }
            conn.Close();
            return list;
        }
    }
}
