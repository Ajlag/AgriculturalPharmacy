namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KreirajPrvo : DbMigration
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
                        TipZemljista = c.String(),
                        stepenOtrovnosti = c.String(),
                        dostupno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.barKod);
            
            CreateTable(
                "dbo.Narudzbinas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        status = c.String(),
                        datum = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Proizvodjacs",
                c => new
                    {
                        oznaka = c.String(nullable: false, maxLength: 128),
                        naziv = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.oznaka);
            
            CreateTable(
                "dbo.PomocniArtikals",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 15),
                        proizvodjac = c.String(),
                        cena = c.Single(nullable: false),
                        datumProizvodnje = c.DateTime(nullable: false),
                        oznaka = c.String(),
                        dostupno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.barKod);
            
            CreateTable(
                "dbo.PrirodnaDjubrivas",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 128),
                        proizvodjac = c.String(),
                        cena = c.Single(nullable: false),
                        TipZemljista = c.String(),
                        datumProizvodnje = c.DateTime(nullable: false),
                        dostupno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.barKod)
                .ForeignKey("dbo.TipZemljistas", t => t.naziv, cascadeDelete: true)
                .Index(t => t.naziv);
            
            CreateTable(
                "dbo.Semenas",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 15),
                        proizvodjac = c.String(),
                        cena = c.Single(nullable: false),
                        datumProizvodnje = c.DateTime(nullable: false),
                        TipZemljista = c.String(),
                        dostupno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.barKod);
            
            CreateTable(
                "dbo.TipZemljistas",
                c => new
                    {
                        naziv = c.String(nullable: false, maxLength: 128),
                        StepenKvaliteta = c.String(),
                        plodnost = c.String(),
                        vlaznost = c.DateTime(nullable: false),
                        specificnost = c.String(nullable: false),
                        dostupno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.naziv);
            
            CreateTable(
                "dbo.VestackaDjubrivas",
                c => new
                    {
                        barKod = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 128),
                        proizvodjac = c.String(),
                        cena = c.Single(nullable: false),
                        TipZemljista = c.String(),
                        datumProizvodnje = c.DateTime(nullable: false),
                        dostupno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.barKod)
                .ForeignKey("dbo.TipZemljistas", t => t.naziv, cascadeDelete: true)
                .Index(t => t.naziv);
            
            CreateTable(
                "dbo.Zaposlenis",
                c => new
                    {
                        KorisnickoIme = c.String(nullable: false, maxLength: 128),
                        lozinka = c.String(nullable: false),
                        ime = c.String(nullable: false, maxLength: 15),
                        prezime = c.String(nullable: false, maxLength: 20),
                        datumRodjenja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KorisnickoIme);
            
            CreateTable(
                "dbo.ProizvodjacNarudzbinas",
                c => new
                    {
                        Proizvodjac_oznaka = c.String(nullable: false, maxLength: 128),
                        Narudzbina_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Proizvodjac_oznaka, t.Narudzbina_id })
                .ForeignKey("dbo.Proizvodjacs", t => t.Proizvodjac_oznaka, cascadeDelete: true)
                .ForeignKey("dbo.Narudzbinas", t => t.Narudzbina_id, cascadeDelete: true)
                .Index(t => t.Proizvodjac_oznaka)
                .Index(t => t.Narudzbina_id);
            
            CreateTable(
                "dbo.PomocniArtikalProizvodjacs",
                c => new
                    {
                        PomocniArtikal_barKod = c.Int(nullable: false),
                        Proizvodjac_oznaka = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PomocniArtikal_barKod, t.Proizvodjac_oznaka })
                .ForeignKey("dbo.PomocniArtikals", t => t.PomocniArtikal_barKod, cascadeDelete: true)
                .ForeignKey("dbo.Proizvodjacs", t => t.Proizvodjac_oznaka, cascadeDelete: true)
                .Index(t => t.PomocniArtikal_barKod)
                .Index(t => t.Proizvodjac_oznaka);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VestackaDjubrivas", "naziv", "dbo.TipZemljistas");
            DropForeignKey("dbo.PrirodnaDjubrivas", "naziv", "dbo.TipZemljistas");
            DropForeignKey("dbo.PomocniArtikalProizvodjacs", "Proizvodjac_oznaka", "dbo.Proizvodjacs");
            DropForeignKey("dbo.PomocniArtikalProizvodjacs", "PomocniArtikal_barKod", "dbo.PomocniArtikals");
            DropForeignKey("dbo.ProizvodjacNarudzbinas", "Narudzbina_id", "dbo.Narudzbinas");
            DropForeignKey("dbo.ProizvodjacNarudzbinas", "Proizvodjac_oznaka", "dbo.Proizvodjacs");
            DropIndex("dbo.PomocniArtikalProizvodjacs", new[] { "Proizvodjac_oznaka" });
            DropIndex("dbo.PomocniArtikalProizvodjacs", new[] { "PomocniArtikal_barKod" });
            DropIndex("dbo.ProizvodjacNarudzbinas", new[] { "Narudzbina_id" });
            DropIndex("dbo.ProizvodjacNarudzbinas", new[] { "Proizvodjac_oznaka" });
            DropIndex("dbo.VestackaDjubrivas", new[] { "naziv" });
            DropIndex("dbo.PrirodnaDjubrivas", new[] { "naziv" });
            DropTable("dbo.PomocniArtikalProizvodjacs");
            DropTable("dbo.ProizvodjacNarudzbinas");
            DropTable("dbo.Zaposlenis");
            DropTable("dbo.VestackaDjubrivas");
            DropTable("dbo.TipZemljistas");
            DropTable("dbo.Semenas");
            DropTable("dbo.PrirodnaDjubrivas");
            DropTable("dbo.PomocniArtikals");
            DropTable("dbo.Proizvodjacs");
            DropTable("dbo.Narudzbinas");
            DropTable("dbo.Hemikalijes");
        }
    }
}
