using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class SemenaRepository : ISemenaRepository
    {
        private DBPoljoprivrednaApoteka context;
        public SemenaRepository(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        }
        public void AddSemena(Semena semena)
        {
            this.context.Semenaa.Add(semena);
        }

        public void DeleteSemena(Semena semena)
        {
            this.context.Semenaa.Remove(semena);
        }

        public Semena FindByNaziv(string naziv)
        {
            return this.context.Semenaa.Where(c => c.naziv == naziv).First();
        }

        public IEnumerable<Semena> GetAllSemena()
        {
            return this.context.Semenaa.ToList();
        }

        public Semena GetSemenaBybarKod(int semenabarKod)
        {
            return this.context.Semenaa.Find(semenabarKod);
        }
    }
}
