using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class PomocniArtikal 
    {
        public string naziv { get; set; }
        public string  oznakaProzivodjacaFK { get; set; }
        public float cena { get; set; }
        public DateTime datumProizvodnje { get; set; }
      
        public int barKod { get; set; }
        public Proizvodjac Proizvodjac { get; set; }
       
        public override string ToString()
        {
            return naziv + " " + cena;
        }
    }
}
