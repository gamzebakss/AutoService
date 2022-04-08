using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
   public class IslemControllers
    {
        public static List<Islem>Listele()
        {
            List<Islem> list = new List<Islem>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select id,Guid,Ad,Fiyat from Islemler", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();








            return list;


        }
    }
}
