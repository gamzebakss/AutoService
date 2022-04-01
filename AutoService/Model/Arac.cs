﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class Arac
    {
        public int id { get; set; }
        public string Plaka { get; set; }
        public int ModelID { get; set; }
        public string SasiNo { get; set; }
        public int Yil { get; set; }
        public string Renk { get; set; }
        public int KullaniciID { get; set; }

        public Model Model { get; set; }
        public List<Fotograf> Fotolar { get; set; }
        public List<Dosya> Dosyalar { get; set; }

    }
}
