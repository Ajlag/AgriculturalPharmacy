namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajla : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zaposlenis", "ime", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zaposlenis", "ime", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
