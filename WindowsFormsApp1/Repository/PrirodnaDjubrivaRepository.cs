 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class PrirodnaDjubrivaRepository : IPrirodnaDjubrivaRepository
    {
        private DBPoljoprivrednaApoteka context;

        public PrirodnaDjubrivaRepository(DBPoljoprivrednaApoteka context) {
            this.context = context;
        }
        public void AddPrirodnaDjubrivas(PrirodnaDjubriva prirodnaDjubriva)
        {
            this.context.PrirodnaDjubrivaa.Add(prirodnaDjubriva);
        }

        public void DeletePrirodnaDjubriva(PrirodnaDjubriva prirodnaDjubriva)
        {
            this.context.PrirodnaDjubrivaa.Remove(prirodnaDjubriva);
        }

        public PrirodnaDjubriva FindByNaziv(string naziv)
        {
            return this.context.PrirodnaDjubrivaa.Where(c => c.naziv == naziv).First();
        }

        public IEnumerable<PrirodnaDjubriva> GetAllPrirodnaDjubrivas()
        {
            return this.context.PrirodnaDjubrivaa.ToList();
        }

        public PrirodnaDjubriva GetPrirodnaDjubrivaBybarKod(int prirodnaDjubrivabarKod)
        {
            return this.context.PrirodnaDjubrivaa.Find(prirodnaDjubrivabarKod);
        }
    }
}
