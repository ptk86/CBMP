namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RodzajBadaniaConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.RodzajBadanias", newName: "RodzajeBadan");
            AlterColumn("dbo.RodzajeBadan", "Nazwa", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RodzajeBadan", "Nazwa", c => c.String());
            RenameTable(name: "dbo.RodzajeBadan", newName: "RodzajBadanias");
        }
    }
}
