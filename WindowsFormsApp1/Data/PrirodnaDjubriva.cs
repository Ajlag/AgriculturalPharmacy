using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class PrirodnaDjubriva
    {
        public string naziv { get; set; }
        public string proizvodjac { get; set; }
        public float cena  { get; set; }
        public string TipZemljista { get; set; }
        public DateTime datumProizvodnje { get; set; }
        public int barKod { get; set; }
        public int dostupno { get; set; }
        public PrirodnaDjubriva(string naziv, string proizvodjac, float cena, string tipzemljista, DateTime datumproizvodnje, int barkod) {
            naziv = naziv;
            proizvodjac = proizvodjac;
            cena = cena;
            TipZemljista = tipzemljista;
            datumProizvodnje = datumproizvodnje;
            barKod = barkod;

        
        }

    }
}
