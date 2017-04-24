namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LokalizacjaConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Lokalizacjas", newName: "Lokalizacje");
            AlterColumn("dbo.Lokalizacje", "Nazwa", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lokalizacje", "Nazwa", c => c.String());
            RenameTable(name: "dbo.Lokalizacje", newName: "Lokalizacjas");
        }
    }
}
