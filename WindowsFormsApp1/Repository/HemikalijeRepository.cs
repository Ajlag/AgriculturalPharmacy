using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class HemikalijeRepository : IHemikalijeRepository
    {
        private DBPoljoprivrednaApoteka context;
        public HemikalijeRepository(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        }
        public void AddHemikalijes(Hemikalije hemikalije)
        {
            this.context.Hemikalijee.Add(hemikalije);
        }

        public void DeleteHemikalije(Hemikalije hemikalije)
        {
            this.context.Hemikalijee.Remove(hemikalije);
        }

        public Hemikalije FindByNaziv(string naziv)
        {
            return this.context.Hemikalijee.Where(c => c.naziv == naziv).First();
        }

        public IEnumerable<Hemikalije> GetAllHemikalijes()
        {
            return this.context.Hemikalijee.ToList();
        }

        public Hemikalije GetHemikalijelBybarKod(int hemikalijebarKod)
        {
            return this.context.Hemikalijee.Find(hemikalijebarKod);
        }
       
    }
}
