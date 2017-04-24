namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KierujacyConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kierujacies", "SieciowiecId", "dbo.Sieciowiecs");
            RenameTable(name: "dbo.Kierujacies", newName: "Kierujacy");
            DropIndex("dbo.Kierujacy", new[] { "SieciowiecId" });
            AlterColumn("dbo.Kierujacy", "Nazwa", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Kierujacy", "SieciowiecId", c => c.Int());
            CreateIndex("dbo.Kierujacy", "SieciowiecId");
            AddForeignKey("dbo.Kierujacy", "SieciowiecId", "dbo.Sieciowiecs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kierujacy", "SieciowiecId", "dbo.Sieciowiecs");
            DropIndex("dbo.Kierujacy", new[] { "SieciowiecId" });
            AlterColumn("dbo.Kierujacy", "SieciowiecId", c => c.Int(nullable: false));
            AlterColumn("dbo.Kierujacy", "Nazwa", c => c.String());
            CreateIndex("dbo.Kierujacy", "SieciowiecId");
            RenameTable(name: "dbo.Kierujacy", newName: "Kierujacies");
            AddForeignKey("dbo.Kierujacies", "SieciowiecId", "dbo.Sieciowiecs", "Id", cascadeDelete: true);
        }
    }
}
