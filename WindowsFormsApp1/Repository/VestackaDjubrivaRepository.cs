using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class VestackaDjubrivaRepository : IVestackaDjubrivaRepository
    {
        private DBPoljoprivrednaApoteka context;
        public VestackaDjubrivaRepository(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        }
        public void AddVestackaDjubrivas(VestackaDjubriva vestackaDjubriva)
        {
            this.context.VestackaDjubrivaa.Add(vestackaDjubriva);
        }

        public void DeleteVestackaDjubriva(VestackaDjubriva vestackaDjubriva)
        {
            this.context.VestackaDjubrivaa.Remove(vestackaDjubriva);
        }

        public VestackaDjubriva FindByNaziv(string naziv)
        {
            return this.context.VestackaDjubrivaa.Where(c => c.naziv == naziv).First();
        }

        public IEnumerable<VestackaDjubriva> GetAllVestackaDjubrivas()
        {
            return this.context.VestackaDjubrivaa.ToList();
        }

        public VestackaDjubriva GetVestackaDjubrivaBybarKod(int vestackaDjubrivabarKod)
        {
            return this.context.VestackaDjubrivaa.Find(vestackaDjubrivabarKod);
        }
    }
}
