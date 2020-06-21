using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public interface IUnitOfWork : IDisposable
    { IHemikalijeRepository Hemikalijee { get;  }
        INarudzbinaRepository Narudzbinaa { get; }
        IPomocniArtikalRepository PomocniArtikall { get; }
        IPrirodnaDjubrivaRepository PrirodnaDjubrivaa { get; }
        IProizvodjacRepository Proizvodjacc { get; }
        ISemenaRepository Semenaa { get; }
        ITipZemljistaRepository TipZemljistaa { get; }
        IVestackaDjubrivaRepository VestackaDjubrivaa { get; }
        IZaposleniRepository Zaposlenii { get; }

        void Complete();
    }
}
