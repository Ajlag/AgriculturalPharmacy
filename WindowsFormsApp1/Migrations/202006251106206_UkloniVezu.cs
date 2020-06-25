namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UkloniVezu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PrirodnaDjubrivas", "naziv", "dbo.TipZemljistas");
            DropForeignKey("dbo.VestackaDjubrivas", "naziv", "dbo.TipZemljistas");
            DropIndex("dbo.PrirodnaDjubrivas", new[] { "naziv" });
            DropIndex("dbo.VestackaDjubrivas", new[] { "naziv" });
            AlterColumn("dbo.PrirodnaDjubrivas", "naziv", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.VestackaDjubrivas", "naziv", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VestackaDjubrivas", "naziv", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PrirodnaDjubrivas", "naziv", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.VestackaDjubrivas", "naziv");
            CreateIndex("dbo.PrirodnaDjubrivas", "naziv");
            AddForeignKey("dbo.VestackaDjubrivas", "naziv", "dbo.TipZemljistas", "naziv", cascadeDelete: true);
            AddForeignKey("dbo.PrirodnaDjubrivas", "naziv", "dbo.TipZemljistas", "naziv", cascadeDelete: true);
        }
    }
}
