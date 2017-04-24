namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringLengthsToPowerOf2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Imiona", "Nazwa", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Miejscowosci", "Nazwa", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Miejscowosci", "Nazwa", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Imiona", "Nazwa", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
