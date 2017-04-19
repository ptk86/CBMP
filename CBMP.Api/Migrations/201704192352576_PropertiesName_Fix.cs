namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertiesName_Fix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Badanies", "Osoba_Id", "dbo.Osoby");
            DropForeignKey("dbo.Badanies", "RodzajBadania_Id", "dbo.RodzajBadanias");
            DropIndex("dbo.Badanies", new[] { "Osoba_Id" });
            DropIndex("dbo.Badanies", new[] { "RodzajBadania_Id" });
            RenameColumn(table: "dbo.Badanies", name: "Osoba_Id", newName: "OsobaId");
            RenameColumn(table: "dbo.Badanies", name: "RodzajBadania_Id", newName: "RodzajBadaniaId");
            AlterColumn("dbo.Badanies", "OsobaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Badanies", "RodzajBadaniaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Badanies", "OsobaId");
            CreateIndex("dbo.Badanies", "RodzajBadaniaId");
            AddForeignKey("dbo.Badanies", "OsobaId", "dbo.Osoby", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Badanies", "RodzajBadaniaId", "dbo.RodzajBadanias", "Id", cascadeDelete: true);
            DropColumn("dbo.Badanies", "IdOsoba");
            DropColumn("dbo.Badanies", "IdRodzajBadania");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Badanies", "IdRodzajBadania", c => c.Int(nullable: false));
            AddColumn("dbo.Badanies", "IdOsoba", c => c.Int(nullable: false));
            DropForeignKey("dbo.Badanies", "RodzajBadaniaId", "dbo.RodzajBadanias");
            DropForeignKey("dbo.Badanies", "OsobaId", "dbo.Osoby");
            DropIndex("dbo.Badanies", new[] { "RodzajBadaniaId" });
            DropIndex("dbo.Badanies", new[] { "OsobaId" });
            AlterColumn("dbo.Badanies", "RodzajBadaniaId", c => c.Int());
            AlterColumn("dbo.Badanies", "OsobaId", c => c.Int());
            RenameColumn(table: "dbo.Badanies", name: "RodzajBadaniaId", newName: "RodzajBadania_Id");
            RenameColumn(table: "dbo.Badanies", name: "OsobaId", newName: "Osoba_Id");
            CreateIndex("dbo.Badanies", "RodzajBadania_Id");
            CreateIndex("dbo.Badanies", "Osoba_Id");
            AddForeignKey("dbo.Badanies", "RodzajBadania_Id", "dbo.RodzajBadanias", "Id");
            AddForeignKey("dbo.Badanies", "Osoba_Id", "dbo.Osoby", "Id");
        }
    }
}
