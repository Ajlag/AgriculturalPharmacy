namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novaBaza : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hemikalijes",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 15),
                        proizvodjac = c.String(),
                        cena = c.Single(nullable: false),
                        datumProizvodnje = c.DateTime(nullable: false),
                        stepenOtrovnosti = c.String(),
                    })
                .PrimaryKey(t => t.barKod)
                .Index(t => t.naziv, unique: true);
            
            CreateTable(
                "dbo.Narudzbinas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        naziv = c.String(),
                        cena = c.Single(nullable: false),
                        kolicina = c.Int(nullable: false),
                        datum = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PomocniArtikals",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 15),
                        oznakaProzivodjacaFK = c.String(nullable: false, maxLength: 128),
                        cena = c.Single(nullable: false),
                        datumProizvodnje = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.barKod)
                .ForeignKey("dbo.Proizvodjacs", t => t.oznakaProzivodjacaFK, cascadeDelete: true)
                .Index(t => t.naziv, unique: true)
                .Index(t => t.oznakaProzivodjacaFK);
            
            CreateTable(
                "dbo.Proizvodjacs",
                c => new
                    {
                        oznaka = c.String(nullable: false, maxLength: 128),
                        naziv = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.oznaka)
                .Index(t => t.naziv, unique: true);
            
            CreateTable(
                "dbo.PrirodnaDjubrivas",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 15),
                        cena = c.Single(nullable: false),
                        NazivZemljistaFK = c.String(nullable: false, maxLength: 128),
                        datumProizvodnje = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.barKod)
                .ForeignKey("dbo.TipZemljistas", t => t.NazivZemljistaFK, cascadeDelete: true)
                .Index(t => t.naziv, unique: true)
                .Index(t => t.NazivZemljistaFK);
            
            CreateTable(
                "dbo.TipZemljistas",
                c => new
                    {
                        nazivZ = c.String(nullable: false, maxLength: 128),
                        StepenKvaliteta = c.String(),
                        plodnost = c.String(),
                        vlaznost = c.String(),
                        specificnost = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.nazivZ);
            
            CreateTable(
                "dbo.VestackaDjubrivas",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 15),
                        cena = c.Single(nullable: false),
                        NazivZemljista = c.String(nullable: false, maxLength: 128),
                        datumProizvodnje = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.barKod)
                .ForeignKey("dbo.TipZemljistas", t => t.NazivZemljista, cascadeDelete: true)
                .Index(t => t.naziv, unique: true)
                .Index(t => t.NazivZemljista);
            
            CreateTable(
                "dbo.Semenas",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 15),
                        oznakaProizvodjacaFK = c.String(),
                        cena = c.Single(nullable: false),
                        datumProizvodnje = c.DateTime(nullable: false),
                        NazivZemljistaFK = c.String(),
                    })
                .PrimaryKey(t => t.barKod)
                .Index(t => t.naziv, unique: true);
            
            CreateTable(
                "dbo.Zaposlenis",
                c => new
                    {
                        KorisnickoIme = c.String(nullable: false, maxLength: 128),
                        lozinka = c.String(nullable: false, maxLength: 20),
                        ime = c.String(nullable: false, maxLength: 20),
                        prezime = c.String(nullable: false, maxLength: 20),
                        datumRodjenja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KorisnickoIme);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrirodnaDjubrivas", "NazivZemljistaFK", "dbo.TipZemljistas");
            DropForeignKey("dbo.VestackaDjubrivas", "NazivZemljista", "dbo.TipZemljistas");
            DropForeignKey("dbo.PomocniArtikals", "oznakaProzivodjacaFK", "dbo.Proizvodjacs");
            DropIndex("dbo.Semenas", new[] { "naziv" });
            DropIndex("dbo.VestackaDjubrivas", new[] { "NazivZemljista" });
            DropIndex("dbo.VestackaDjubrivas", new[] { "naziv" });
            DropIndex("dbo.PrirodnaDjubrivas", new[] { "NazivZemljistaFK" });
            DropIndex("dbo.PrirodnaDjubrivas", new[] { "naziv" });
            DropIndex("dbo.Proizvodjacs", new[] { "naziv" });
            DropIndex("dbo.PomocniArtikals", new[] { "oznakaProzivodjacaFK" });
            DropIndex("dbo.PomocniArtikals", new[] { "naziv" });
            DropIndex("dbo.Hemikalijes", new[] { "naziv" });
            DropTable("dbo.Zaposlenis");
            DropTable("dbo.Semenas");
            DropTable("dbo.VestackaDjubrivas");
            DropTable("dbo.TipZemljistas");
            DropTable("dbo.PrirodnaDjubrivas");
            DropTable("dbo.Proizvodjacs");
            DropTable("dbo.PomocniArtikals");
            DropTable("dbo.Narudzbinas");
            DropTable("dbo.Hemikalijes");
        }
    }
}
