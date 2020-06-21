﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class PomocniArtikal
    {
        public string naziv { get; set; }
        public string proizvodjac { get; set; }
        public float cena { get; set; }
        public DateTime datumProizvodnje { get; set; }
       public string oznaka {  get; set; }
        public int barKod { get; set; }
        public ICollection<Proizvodjac> Proizvodjacs { get; set; }
        public int dostupno { get; set; }
    }
}