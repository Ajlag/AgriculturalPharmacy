using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
 public   interface INarudzbinaRepository
    {
        IEnumerable<Narudzbina> GetAllNarudzbina();
        void AddNarudzbinas(Narudzbina narudzbina);
        Narudzbina GetNarudzbinaId(int id);
        void DeleteNarudzbina(Narudzbina narudzbina);
        Narudzbina FindById(int id);
    }
}
