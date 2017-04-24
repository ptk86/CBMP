namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PracodwacaSepllingCorrection : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Badania", name: "PracodawdaId", newName: "PracodawcaId");
            RenameIndex(table: "dbo.Badania", name: "IX_PracodawdaId", newName: "IX_PracodawcaId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Badania", name: "IX_PracodawcaId", newName: "IX_PracodawdaId");
            RenameColumn(table: "dbo.Badania", name: "PracodawcaId", newName: "PracodawdaId");
        }
    }
}
