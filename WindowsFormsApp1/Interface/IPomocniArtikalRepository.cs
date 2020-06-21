using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  interface IPomocniArtikalRepository
    {
        IEnumerable<PomocniArtikal> GetAllPomocniArtikals();
        void AddPomocniArtikals(PomocniArtikal pomocniArtikal);
        PomocniArtikal GetPomocniArtikalBybarKod(int pomocniArtikalbarKod);
        void DeletePomocniArtikal(PomocniArtikal pomocniArtikal);
        PomocniArtikal FindByNaziv(string naziv);
    }
}
