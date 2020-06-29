namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Hemikalijes", "dostupno");
            DropColumn("dbo.PomocniArtikals", "dostupno");
            DropColumn("dbo.PrirodnaDjubrivas", "dostupno");
            DropColumn("dbo.Semenas", "dostupno");
            DropColumn("dbo.VestackaDjubrivas", "dostupno");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VestackaDjubrivas", "dostupno", c => c.Int(nullable: false));
            AddColumn("dbo.Semenas", "dostupno", c => c.Int(nullable: false));
            AddColumn("dbo.PrirodnaDjubrivas", "dostupno", c => c.Int(nullable: false));
            AddColumn("dbo.PomocniArtikals", "dostupno", c => c.Int(nullable: false));
            AddColumn("dbo.Hemikalijes", "dostupno", c => c.Int(nullable: false));
        }
    }
}
