using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
 public   interface IVestackaDjubrivaRepository
    {
        IEnumerable<VestackaDjubriva> GetAllVestackaDjubrivas();
        void AddVestackaDjubrivas(VestackaDjubriva vestackaDjubriva);
        VestackaDjubriva GetVestackaDjubrivaBybarKod(int vestackaDjubrivabarKod);
        void DeleteVestackaDjubriva(VestackaDjubriva vestackaDjubriva);
        VestackaDjubriva FindByNaziv(string naziv);
    }
}
