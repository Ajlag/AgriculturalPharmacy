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
      
     //   public ICollection<TipZemljista> TipZemljistas { get; set; }
     
        public override string ToString()
        {
            return naziv + " " + cena;
        }
        
    }
}
