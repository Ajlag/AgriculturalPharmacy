using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public  class ZaposleniRepository:IZaposleniRepository
    {
        private DBPoljoprivrednaApoteka context;
        public ZaposleniRepository(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        }

       

        public void AddZaposleni(Zaposleni zaposleni)
        {
            this.context.Zaposlenii.Add(zaposleni);
        }

        public bool CombinationExists(string Korisnickoime, string Lozinka)
        {
            var count = context.Zaposlenii.Where(x => x.KorisnickoIme == Korisnickoime && x.lozinka == Lozinka).Count();
            return count == 1 ? true : false;
        }


        public void DeleteZaposleni(Zaposleni zaposleni)
        {
            this.context.Zaposlenii.Remove(zaposleni);
        }

        public Zaposleni FindBySurname(string prezime)
        {
            return this.context.Zaposlenii.Where(c => c.prezime == prezime).First();

        }

        public IEnumerable<Zaposleni> GetAllZaposlenis()
        {
            return this.context.Zaposlenii.ToList();


        }

        public Zaposleni GetZaposleniByKorisnickoIme(string zaposleniKorisnickoIme)
        {
            return this.context.Zaposlenii.Find(zaposleniKorisnickoIme);
        }


      
        }
}
