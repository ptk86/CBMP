namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImieConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Imies", newName: "Imiona");
            AlterColumn("dbo.Imiona", "Nazwa", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Imiona", "Nazwa", c => c.String());
            RenameTable(name: "dbo.Imiona", newName: "Imies");
        }
    }
}
