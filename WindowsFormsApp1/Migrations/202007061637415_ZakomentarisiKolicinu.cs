namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZakomentarisiKolicinu : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Hemikalijes", "kolicina");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hemikalijes", "kolicina", c => c.Int(nullable: false));
        }
    }
}
