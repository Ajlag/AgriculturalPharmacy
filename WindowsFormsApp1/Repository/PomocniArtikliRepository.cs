using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class PomocniArtikliRepository : IPomocniArtikalRepository
    {
        private DBPoljoprivrednaApoteka context;
        public PomocniArtikliRepository(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        }
        public void AddPomocniArtikals(PomocniArtikal pomocniArtikal)
        {
            this.context.PomocniArtikall.Add(pomocniArtikal);
        }

        public void DeletePomocniArtikal(PomocniArtikal pomocniArtikal)
        {
            this.context.PomocniArtikall.Remove(pomocniArtikal);
        }

        public PomocniArtikal FindByNaziv(string naziv)
        {
            return this.context.PomocniArtikall.Where(c => c.naziv == naziv).First();
        }

        public IEnumerable<PomocniArtikal> GetAllPomocniArtikals()
        {
            return this.context.PomocniArtikall.ToList();
        }

        public PomocniArtikal GetPomocniArtikalBybarKod(int pomocniArtikalbarKod)
        {
            return this.context.PomocniArtikall.Find(pomocniArtikalbarKod);
        }
    }
}
