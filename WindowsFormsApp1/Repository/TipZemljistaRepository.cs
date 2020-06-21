using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TipZemljistaRepository : ITipZemljistaRepository
    {
        private DBPoljoprivrednaApoteka context;
        public TipZemljistaRepository(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        }
        public void AddTipZemljista(TipZemljista tipZemljista)
        {
            this.context.TipZemljistaa.Add(tipZemljista);
        }

        public TipZemljista FindByNaziv(string naziv)
        {
            return this.context.TipZemljistaa.Where(c => c.naziv == naziv).First();
        }

        public IEnumerable<TipZemljista> GetAllTipZemljistas()
        {
            return this.context.TipZemljistaa.ToList();
        }

        public TipZemljista GetTipZemljista(string naziv)
        {
            return this.context.TipZemljistaa.Find(naziv);
        }
        public void DeleteTipZemljista(TipZemljista tipZemljista)
        {
            this.context.TipZemljistaa.Remove(tipZemljista);
        }
    }
}
