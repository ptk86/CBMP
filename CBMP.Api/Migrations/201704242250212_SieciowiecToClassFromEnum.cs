namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SieciowiecToClassFromEnum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sieciowiecs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Kierujacies", "SieciowiecId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kierujacies", "SieciowiecId");
            AddForeignKey("dbo.Kierujacies", "SieciowiecId", "dbo.Sieciowiecs", "Id", cascadeDelete: true);
            DropColumn("dbo.Kierujacies", "Sieciowiec");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kierujacies", "Sieciowiec", c => c.Int(nullable: false));
            DropForeignKey("dbo.Kierujacies", "SieciowiecId", "dbo.Sieciowiecs");
            DropIndex("dbo.Kierujacies", new[] { "SieciowiecId" });
            DropColumn("dbo.Kierujacies", "SieciowiecId");
            DropTable("dbo.Sieciowiecs");
        }
    }
}
