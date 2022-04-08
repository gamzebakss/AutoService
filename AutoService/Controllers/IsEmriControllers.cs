using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class IsEmriControllers
    {
        public static bool Ekle(isEmri isemri)
        {
            try
            {

                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("Insert Into IsEmirleri([AracID],[OlusturmaTarihi],[Aciklama],[Durum],[TeslimEden],[TeslimAlan],[TurID]) values (@aracid,GETDATE(),@aciklama,@durum,@teslimeden,@teslimalan,@turid)", conn);
                cmd.Parameters.AddWithValue("@aracid", isemri.Arac.id);
                cmd.Parameters.AddWithValue("@aciklama", isemri.Aciklama);
                cmd.Parameters.AddWithValue("@durum", isemri.Durum);
                cmd.Parameters.AddWithValue("@teslimeden", isemri.TeslimEden);
                cmd.Parameters.AddWithValue("@teslimalan", isemri.TeslimAlan);
                cmd.Parameters.AddWithValue("@turid", isemri.IsEmriTuru.id);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
                return true;

            }
            catch(Exception ex)
            {
                return false;

            }
                
            
        }

       public static List<isEmri> Listele(int Durum)
        {
            List<isEmri> list = new List<isEmri>();
            try
            {
                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("SELECT [id],[AracID],[OlusturmaTarihi],[Aciklama],[Durum],[TeslimEden],[TeslimAlan],[TurID],(select Ad from IsEmirleriTurleri where id=TurID) as GelisSebebi From [dbo].[IsEmirleri] where Durum=@durum", conn);
                cmd.Parameters.AddWithValue("@durum", Durum);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new isEmri { Aciklama = dr["Aciklama"].ToString(), Durum = Durum, id = (int)dr["id"], OlusturmaTarihi = (DateTime)dr["OlusturmaTarihi"], TeslimAlan = dr["TeslimAlan"].ToString(), TeslimEden = dr["TelimEden"].ToString(), IsEmriTuru = new IsEmriTuru { Ad = dr["GelisSebebi"].ToString(), id = (int)dr["TurID"] }, Arac = AracControllers.Getir((int)dr["AracID"]) });
                    conn.Close();

                    /////
                }

                return list;

            }
            catch 
            {

                return list;
            }
        }

    }
}
