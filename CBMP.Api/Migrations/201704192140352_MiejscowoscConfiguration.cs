namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MiejscowoscConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Miejscowoscs", newName: "Miejscowosci");
            AlterColumn("dbo.Miejscowosci", "Nazwa", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Miejscowosci", "Nazwa", c => c.String());
            RenameTable(name: "dbo.Miejscowosci", newName: "Miejscowoscs");
        }
    }
}
