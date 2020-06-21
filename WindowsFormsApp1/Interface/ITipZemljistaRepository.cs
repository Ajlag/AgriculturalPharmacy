using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public interface ITipZemljistaRepository
    {
        IEnumerable<TipZemljista> GetAllTipZemljistas();
        void AddTipZemljista(TipZemljista tipZemljista);
        TipZemljista GetTipZemljista(string naziv);
        void DeleteTipZemljista(TipZemljista tipZemljista);
        TipZemljista FindByNaziv(string naziv);
    }
}
