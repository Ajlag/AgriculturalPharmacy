using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class DBPoljoprivrednaApoteka : DbContext
    {
        public DbSet<Zaposleni> Zaposlenii { get; set; }
        public DbSet<VestackaDjubriva> VestackaDjubrivaa { get; set; }
        public DbSet<TipZemljista> TipZemljistaa { get; set; }
        public DbSet<Semena> Semenaa { get; set; }
        public DbSet<Proizvodjac> Proizvodjacc { get; set; }
        public DbSet<PrirodnaDjubriva> PrirodnaDjubrivaa { get; set; }
        public DbSet<PomocniArtikal> PomocniArtikall { get; set; }
        public DbSet<Narudzbina> Narudzbinaa { get; set; }
        public DbSet<Hemikalije> Hemikalijee { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Zaposleni>().HasKey(z => z.KorisnickoIme );
            modelBuilder.Entity<Zaposleni>().Property(z => z.ime).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Zaposleni>().Property(z => z.prezime).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Zaposleni>().Property(z => z.datumRodjenja).IsRequired();
            modelBuilder.Entity<Zaposleni>().Property(z => z.lozinka).IsRequired();
            modelBuilder.Entity<Zaposleni>().Property(ca => ca.lozinka).HasMaxLength(20);

            modelBuilder.Entity<VestackaDjubriva>().HasKey(z => z.barKod );
            modelBuilder.Entity<VestackaDjubriva>().HasIndex(u => u.naziv).IsUnique();
            modelBuilder.Entity<VestackaDjubriva>().Property(z => z.naziv).IsRequired().HasMaxLength(15);

            modelBuilder.Entity<VestackaDjubriva>().Property(z => z.naziv);
            modelBuilder.Entity<VestackaDjubriva>().Property(z => z.datumProizvodnje).IsRequired();
            modelBuilder.Entity<VestackaDjubriva>().Property(z => z.cena).IsRequired();
           





            modelBuilder.Entity<TipZemljista>().HasKey(s => s.nazivZ);
            modelBuilder.Entity<TipZemljista>().Property(s => s.specificnost).IsRequired();
            modelBuilder.Entity<Semena>().HasIndex(u => u.naziv).IsUnique();
            modelBuilder.Entity<Semena>().HasKey(s => s.barKod);
            modelBuilder.Entity<Semena>().Property(z => z.naziv).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Semena>().Property(z => z.datumProizvodnje).IsRequired();
            modelBuilder.Entity<Semena>().Property(z => z.cena).IsRequired();
           


            modelBuilder.Entity<Proizvodjac>().HasKey(s => s.oznaka);
            modelBuilder.Entity<Proizvodjac>().Property(z => z.naziv).IsRequired().HasMaxLength(15);
           modelBuilder.Entity<Proizvodjac>().HasIndex(u => u.naziv).IsUnique();


            modelBuilder.Entity<PrirodnaDjubriva>().HasKey(s => s.barKod);
            modelBuilder.Entity<PrirodnaDjubriva>().Property(z => z.naziv).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<PrirodnaDjubriva>().HasIndex(u => u.naziv).IsUnique();
            modelBuilder.Entity<PrirodnaDjubriva>().Property(z => z.datumProizvodnje).IsRequired();
            modelBuilder.Entity<PrirodnaDjubriva>().Property(z => z.cena).IsRequired();
           

            modelBuilder.Entity<PomocniArtikal>().HasKey(s => s.barKod);
            modelBuilder.Entity<PomocniArtikal>().Property(z => z.naziv).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<PomocniArtikal>().HasIndex(u => u.naziv).IsUnique();
            modelBuilder.Entity<PomocniArtikal>().Property(z => z.datumProizvodnje).IsRequired();
            modelBuilder.Entity<PomocniArtikal>().Property(z => z.cena).IsRequired();
           

            modelBuilder.Entity<Narudzbina>().HasKey(s => s.id);

            modelBuilder.Entity<Hemikalije>().HasKey(s => s.barKod);
            modelBuilder.Entity<Hemikalije>().Property(z => z.naziv).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Hemikalije>().HasIndex(u => u.naziv).IsUnique();
            modelBuilder.Entity<Hemikalije>().Property(z => z.datumProizvodnje).IsRequired();
            modelBuilder.Entity<Hemikalije>().Property(z => z.cena).IsRequired();

        
            modelBuilder.Entity<PomocniArtikal>().HasRequired(d => d.Proizvodjac).WithMany(v => v.PomocniArtikals).HasForeignKey(d => d.oznakaProzivodjacaFK);
            modelBuilder.Entity<PrirodnaDjubriva>().HasRequired(d => d.TipZemljista).WithMany(v => v.PrirodnaDjubrivas).HasForeignKey(d => d.NazivZemljistaFK);
            modelBuilder.Entity<VestackaDjubriva>().HasRequired(d => d.TipZemljista).WithMany(v => v.VestackaDjubrivas).HasForeignKey(d => d.NazivZemljista);

          
        }





    }





}
    

