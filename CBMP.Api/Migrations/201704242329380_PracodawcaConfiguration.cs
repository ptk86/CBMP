namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PracodawcaConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pracodawcas", newName: "Pracodawcy");
            AlterColumn("dbo.Pracodawcy", "Nazwa", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pracodawcy", "Nazwa", c => c.String());
            RenameTable(name: "dbo.Pracodawcy", newName: "Pracodawcas");
        }
    }
}
