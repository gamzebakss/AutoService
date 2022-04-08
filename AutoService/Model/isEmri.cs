using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class isEmri
    {
        public int id { get; set; }
       
        public Arac Arac { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public string Aciklama { get; set; }
        public int Durum { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
        public IsEmriTuru IsEmriTuru { get; set; }
       

    }
}
