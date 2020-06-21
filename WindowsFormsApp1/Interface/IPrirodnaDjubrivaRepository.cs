using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public interface IPrirodnaDjubrivaRepository
    {
        IEnumerable<PrirodnaDjubriva> GetAllPrirodnaDjubrivas();
        void AddPrirodnaDjubrivas(PrirodnaDjubriva prirodnaDjubriva);
        PrirodnaDjubriva GetPrirodnaDjubrivaBybarKod(int prirodnaDjubrivabarKod);
        void DeletePrirodnaDjubriva(PrirodnaDjubriva prirodnaDjubriva);
        PrirodnaDjubriva FindByNaziv(string naziv);
    }
}
