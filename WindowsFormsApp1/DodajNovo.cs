using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DodajNovo: System.Data.Entity. DropCreateDatabaseIfModelChanges<DBPoljoprivrednaApoteka>
    {  protected override void Seed(DBPoljoprivrednaApoteka context) {
            var zaposleni = new List<Zaposleni>
            {
            new Zaposleni{ime="Ajla",prezime="Gudzevic",datumRodjenja=DateTime.Parse("1998-07-01"),KorisnickoIme="ajlaag",lozinka="123"},
            new Zaposleni{ime="Admin",prezime="Admin",datumRodjenja=DateTime.Parse("1998-07-01"),KorisnickoIme="admin",lozinka="admin"},
              };

            zaposleni.ForEach(s => context.Zaposlenii.Add(s));
            context.SaveChanges();
        } }
    }

