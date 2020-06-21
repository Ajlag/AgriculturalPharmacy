using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public interface IProizvodjacRepository
    {
        IEnumerable<Proizvodjac> GetAllProizvodjac();
        void AddProizvodjac(Proizvodjac proizvodjac);
        Proizvodjac GetProizvodjacOznaka(string oznaka);
        void DeleteProizvodjac(Proizvodjac proizvodjac);
        Proizvodjac FindByOznaka(string oznaka);
    }
}
