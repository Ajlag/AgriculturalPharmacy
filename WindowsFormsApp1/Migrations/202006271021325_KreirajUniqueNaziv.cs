namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KreirajUniqueNaziv : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.VestackaDjubrivas", "naziv", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.VestackaDjubrivas", new[] { "naziv" });
        }
    }
}
