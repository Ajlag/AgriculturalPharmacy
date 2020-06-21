using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Proizvodjac
    {
        public string naziv { get; set; }
        public string oznaka { get; set; }

        public ICollection<PomocniArtikal> PomocniArtikals { get; set; }
        public ICollection<Narudzbina> Narudzbinas { get; set; }
    }
}
