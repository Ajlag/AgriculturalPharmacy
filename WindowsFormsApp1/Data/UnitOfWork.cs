using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class UnitOfWork : IUnitOfWork
    {
        private DBPoljoprivrednaApoteka context;
        private HemikalijeRepository hemikalijee;
        private NarudzbinaRepository narudzbinaa;
        private PomocniArtikliRepository pomocniartikall;
        private PrirodnaDjubrivaRepository prirodnadjubrivaa;
        private ProizvodjacRepository proizvodjacc;
        private SemenaRepository semenaa;
        private TipZemljistaRepository tipzemljistaa;
        private VestackaDjubrivaRepository vestackadjubrivaa;
        private ZaposleniRepository zaposlenii;

        public UnitOfWork(DBPoljoprivrednaApoteka context)
        {
            this.context = context;
        
        }
     
   
        public IPrirodnaDjubrivaRepository PrirodnaDjubrivaa {
            get
            {

                return prirodnadjubrivaa ?? (prirodnadjubrivaa = new PrirodnaDjubrivaRepository(context));
            }
        
        }
        public IProizvodjacRepository Proizvodjacc {
            get {
                return proizvodjacc ?? (proizvodjacc = new ProizvodjacRepository(context));
            }
        
        }
        public ISemenaRepository Semenaa
        {
            get {

                return semenaa ?? (semenaa = new SemenaRepository(context));

            }
        }

        public ITipZemljistaRepository TipZemljistaa {
            get {
                return tipzemljistaa ?? (tipzemljistaa = new TipZemljistaRepository(context));
            }
        }
        public IVestackaDjubrivaRepository VestackaDjubrivaa {
            get {
                return vestackadjubrivaa ?? (vestackadjubrivaa = new VestackaDjubrivaRepository(context));
            }
        
        }

        public IZaposleniRepository Zaposlenii {
            get
            {
                return zaposlenii ?? (zaposlenii = new ZaposleniRepository(context));
            }
        }

        public IHemikalijeRepository Hemikalijee {

            get
            {
                return hemikalijee ?? (hemikalijee = new HemikalijeRepository(context));
            }
        }

        public INarudzbinaRepository Narudzbinaa => throw new NotImplementedException();

        public IPomocniArtikalRepository PomocniArtikall {
            get {
                return pomocniartikall ?? (pomocniartikall = new PomocniArtikliRepository(context));
            }
        }

        public void Complete()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
