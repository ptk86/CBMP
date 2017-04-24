namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BadanieConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Badanies", "KierujacyId", "dbo.Kierujacies");
            DropForeignKey("dbo.Badanies", "LokalizacjaId", "dbo.Lokalizacjas");
            DropForeignKey("dbo.Badanies", "OsobaId", "dbo.Osoby");
            DropForeignKey("dbo.Badanies", "RodzajBadaniaId", "dbo.RodzajBadanias");
            RenameTable(name: "dbo.Badanies", newName: "Badania");
            DropIndex("dbo.Badania", new[] { "Badajcy_Id" });
            DropIndex("dbo.Badania", new[] { "Pracodawca_Id" });
            DropColumn("dbo.Badania", "PracodawdaId");
            RenameColumn(table: "dbo.Badania", name: "Badajcy_Id", newName: "BadajacyId");
            RenameColumn(table: "dbo.Badania", name: "Pracodawca_Id", newName: "PracodawdaId");
            AlterColumn("dbo.Badania", "Data", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Badania", "BadajacyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Badania", "PracodawdaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Badania", "BadajacyId");
            CreateIndex("dbo.Badania", "PracodawdaId");
            AddForeignKey("dbo.Badania", "KierujacyId", "dbo.Kierujacies", "Id");
            AddForeignKey("dbo.Badania", "LokalizacjaId", "dbo.Lokalizacjas", "Id");
            AddForeignKey("dbo.Badania", "OsobaId", "dbo.Osoby", "Id");
            AddForeignKey("dbo.Badania", "RodzajBadaniaId", "dbo.RodzajBadanias", "Id");
            DropColumn("dbo.Badania", "IdBadajacy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Badania", "IdBadajacy", c => c.Int(nullable: false));
            DropForeignKey("dbo.Badania", "RodzajBadaniaId", "dbo.RodzajBadanias");
            DropForeignKey("dbo.Badania", "OsobaId", "dbo.Osoby");
            DropForeignKey("dbo.Badania", "LokalizacjaId", "dbo.Lokalizacjas");
            DropForeignKey("dbo.Badania", "KierujacyId", "dbo.Kierujacies");
            DropIndex("dbo.Badania", new[] { "PracodawdaId" });
            DropIndex("dbo.Badania", new[] { "BadajacyId" });
            AlterColumn("dbo.Badania", "PracodawdaId", c => c.Int());
            AlterColumn("dbo.Badania", "BadajacyId", c => c.Int());
            AlterColumn("dbo.Badania", "Data", c => c.DateTime(nullable: false));
            RenameColumn(table: "dbo.Badania", name: "PracodawdaId", newName: "Pracodawca_Id");
            RenameColumn(table: "dbo.Badania", name: "BadajacyId", newName: "Badajcy_Id");
            AddColumn("dbo.Badania", "PracodawdaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Badania", "Pracodawca_Id");
            CreateIndex("dbo.Badania", "Badajcy_Id");
            RenameTable(name: "dbo.Badania", newName: "Badanies");
            AddForeignKey("dbo.Badanies", "RodzajBadaniaId", "dbo.RodzajBadanias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Badanies", "OsobaId", "dbo.Osoby", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Badanies", "LokalizacjaId", "dbo.Lokalizacjas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Badanies", "KierujacyId", "dbo.Kierujacies", "Id", cascadeDelete: true);
        }
    }
}
