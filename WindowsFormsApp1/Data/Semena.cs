using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class Semena
    {
        public string naziv { get; set; }
        public string oznakaProizvodjacaFK { get; set; }
        public float cena { get; set; }
        public DateTime datumProizvodnje { get; set; }
        public string NazivZemljistaFK { get; set; }
        public int barKod { get; set; }
       
       
        public override string ToString()
        {
            return naziv + " " + cena;
        }

    } 
}
