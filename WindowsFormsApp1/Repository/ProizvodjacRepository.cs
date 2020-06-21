using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ProizvodjacRepository : IProizvodjacRepository
    {
        private DBPoljoprivrednaApoteka context;
        public ProizvodjacRepository(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        }
        public void AddProizvodjac(Proizvodjac proizvodjac)
        {
            this.context.Proizvodjacc.Add(proizvodjac);
        }

        public void DeleteProizvodjac(Proizvodjac proizvodjac)
        {
            this.context.Proizvodjacc.Remove(proizvodjac);
        }

        public Proizvodjac FindByOznaka(string oznaka)
        {
            return this.context.Proizvodjacc.Where(c => c.oznaka == oznaka).First();
        }

        public IEnumerable<Proizvodjac> GetAllProizvodjac()
        {
            return this.context.Proizvodjacc.ToList();
        }

        public Proizvodjac GetProizvodjacOznaka(string oznaka)
        {
            return this.context.Proizvodjacc.Find(oznaka);
        }
    }
}
