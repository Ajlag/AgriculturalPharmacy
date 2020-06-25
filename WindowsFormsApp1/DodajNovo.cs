using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DodajNovo
    { public static System.Collections.Generic.List<Zaposleni> GetZaposlenis() {
            List<Zaposleni> zaposleni = new List<Zaposleni>()
            {
                new Zaposleni() {
                KorisnickoIme="ajlaag",
                ime="Ajla",
                prezime="Gudzevic",
                lozinka="123"
                }

            };
            return zaposleni;
        }
    }
}
