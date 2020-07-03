using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class TipZemljista
    {
        public string nazivZ { get; set; }
        public string StepenKvaliteta { get; set; }
        public string plodnost { get; set; }
        public string vlaznost { get; set; } 
        public string specificnost { get; set; }
      
        
         public ICollection<PrirodnaDjubriva> PrirodnaDjubrivas { get; set; }
         public ICollection<VestackaDjubriva> VestackaDjubrivas { get; set; }
       


    }
}
