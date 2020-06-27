namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueNazivZaSve : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Hemikalijes", "naziv", unique: true);
            CreateIndex("dbo.Proizvodjacs", "naziv", unique: true);
            CreateIndex("dbo.PomocniArtikals", "naziv", unique: true);
            CreateIndex("dbo.PrirodnaDjubrivas", "naziv", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.PrirodnaDjubrivas", new[] { "naziv" });
            DropIndex("dbo.PomocniArtikals", new[] { "naziv" });
            DropIndex("dbo.Proizvodjacs", new[] { "naziv" });
            DropIndex("dbo.Hemikalijes", new[] { "naziv" });
        }
    }
}
