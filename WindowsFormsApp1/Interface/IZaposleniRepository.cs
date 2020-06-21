using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IZaposleniRepository
    {

        IEnumerable<Zaposleni> GetAllZaposlenis();
        void AddZaposleni(Zaposleni zaposleni);
        Zaposleni GetZaposleniByKorisnickoIme(string zaposleniKorisnickoIme );
        void DeleteZaposleni(Zaposleni zaposleni);
        Zaposleni FindBySurname(string prezime);
        bool CombinationExists(string Korisnickoime, string Lozinkai);

    }
}
