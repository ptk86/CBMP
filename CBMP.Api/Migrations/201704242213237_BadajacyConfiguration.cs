namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BadajacyConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Badajcies", newName: "Badajacy");
            AddColumn("dbo.Badajacy", "Imie", c => c.String(nullable: false, maxLength: 32));
            AddColumn("dbo.Badajacy", "Nazwisko", c => c.String(nullable: false, maxLength: 32));
            DropColumn("dbo.Badajacy", "Nazwa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Badajacy", "Nazwa", c => c.String());
            DropColumn("dbo.Badajacy", "Nazwisko");
            DropColumn("dbo.Badajacy", "Imie");
            RenameTable(name: "dbo.Badajacy", newName: "Badajcies");
        }
    }
}
