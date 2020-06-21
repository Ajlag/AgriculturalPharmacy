using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
 public   interface IHemikalijeRepository
    {
        IEnumerable<Hemikalije> GetAllHemikalijes();
        void AddHemikalijes(Hemikalije hemikalije);
        Hemikalije GetHemikalijelBybarKod(int hemikalijebarKod);
        void DeleteHemikalije(Hemikalije hemikalije);
        Hemikalije FindByNaziv(string naziv);
    }
}
