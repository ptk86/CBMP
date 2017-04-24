namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SieciowiecConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kierujacy", "SieciowiecId", "dbo.Sieciowiecs");
            RenameTable(name: "dbo.Sieciowiecs", newName: "Sieciowcy");
            DropIndex("dbo.Kierujacy", new[] { "SieciowiecId" });
            AddColumn("dbo.Badania", "SieciowiecId", c => c.Int());
            AlterColumn("dbo.Sieciowcy", "Nazwa", c => c.String(nullable: false, maxLength: 32));
            CreateIndex("dbo.Badania", "SieciowiecId");
            AddForeignKey("dbo.Badania", "SieciowiecId", "dbo.Sieciowcy", "Id");
            DropColumn("dbo.Kierujacy", "SieciowiecId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kierujacy", "SieciowiecId", c => c.Int());
            DropForeignKey("dbo.Badania", "SieciowiecId", "dbo.Sieciowcy");
            DropIndex("dbo.Badania", new[] { "SieciowiecId" });
            AlterColumn("dbo.Sieciowcy", "Nazwa", c => c.String());
            DropColumn("dbo.Badania", "SieciowiecId");
            CreateIndex("dbo.Kierujacy", "SieciowiecId");
            RenameTable(name: "dbo.Sieciowcy", newName: "Sieciowiecs");
            AddForeignKey("dbo.Kierujacy", "SieciowiecId", "dbo.Sieciowiecs", "Id");
        }
    }
}
