using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NarudzbinaRepository : INarudzbinaRepository
    {
        private DBPoljoprivrednaApoteka context;
        public NarudzbinaRepository(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        }
        public void AddNarudzbinas(Narudzbina narudzbina)
        {
            this.context.Narudzbinaa.Add(narudzbina);
        }

        public void DeleteNarudzbina(Narudzbina narudzbina)
        {
            this.context.Narudzbinaa.Remove(narudzbina);
        }

        public Narudzbina FindById(int id)
        {
            return this.context.Narudzbinaa.Where(c => c.id == id).First();
        }

        public IEnumerable<Narudzbina> GetAllNarudzbina()
        {
            return this.context.Narudzbinaa.ToList();
        }

        public Narudzbina GetNarudzbinaId(int id)
        {
            return this.context.Narudzbinaa.Find(id);
        }
    }
}
