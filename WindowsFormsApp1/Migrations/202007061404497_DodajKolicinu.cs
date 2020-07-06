namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajKolicinu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hemikalijes", "kolicina", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hemikalijes", "kolicina");
        }
    }
}
