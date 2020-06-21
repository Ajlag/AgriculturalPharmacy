using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public  interface ISemenaRepository
    {
        IEnumerable<Semena> GetAllSemena();
        void AddSemena(Semena semena);
        Semena GetSemenaBybarKod(int semenabarKod);
        void DeleteSemena(Semena semena);
        Semena FindByNaziv(string naziv);
    }
}

