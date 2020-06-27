namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemenaUnique1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Semenas", "naziv", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Semenas", new[] { "naziv" });
        }
    }
}
