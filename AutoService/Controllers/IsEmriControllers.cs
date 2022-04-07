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
                cmd.Parameters.AddWithValue("@aracid", isemri.AracID);
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

    }
}
