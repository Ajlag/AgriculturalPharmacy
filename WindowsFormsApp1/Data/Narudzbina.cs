using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class Narudzbina
    {
        public string status { get; set; }
        public int id{ get; set; }
        public DateTime datum { get; set; }
        public ICollection<Proizvodjac> Proizvodjacs { get; set; }

    }
}
