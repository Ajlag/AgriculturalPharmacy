namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KreirajNarudzbina : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Narudzbinas", "naziv", c => c.String());
            AddColumn("dbo.Narudzbinas", "cena", c => c.Single(nullable: false));
            AddColumn("dbo.Narudzbinas", "kolicina", c => c.Int(nullable: false));
            DropColumn("dbo.Narudzbinas", "status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Narudzbinas", "status", c => c.String());
            DropColumn("dbo.Narudzbinas", "kolicina");
            DropColumn("dbo.Narudzbinas", "cena");
            DropColumn("dbo.Narudzbinas", "naziv");
        }
    }
}
