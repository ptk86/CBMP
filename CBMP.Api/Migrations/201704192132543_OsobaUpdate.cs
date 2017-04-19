namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OsobaUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Osobas", "Miejscowosc_Id", "dbo.Miejscowoscs");
            AddColumn("dbo.Osobas", "IdMiejsceUrodzenia", c => c.Int(nullable: false));
            AddColumn("dbo.Osobas", "IdMiejscowosc", c => c.Int(nullable: false));
            AddColumn("dbo.Osobas", "Miejscowosc_Id1", c => c.Int());
            CreateIndex("dbo.Osobas", "Miejscowosc_Id1");
            AddForeignKey("dbo.Osobas", "Miejscowosc_Id", "dbo.Miejscowoscs", "Id");
            AddForeignKey("dbo.Osobas", "Miejscowosc_Id1", "dbo.Miejscowoscs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Osobas", "Miejscowosc_Id1", "dbo.Miejscowoscs");
            DropForeignKey("dbo.Osobas", "Miejscowosc_Id", "dbo.Miejscowoscs");
            DropIndex("dbo.Osobas", new[] { "Miejscowosc_Id1" });
            DropColumn("dbo.Osobas", "Miejscowosc_Id1");
            DropColumn("dbo.Osobas", "IdMiejscowosc");
            DropColumn("dbo.Osobas", "IdMiejsceUrodzenia");
            AddForeignKey("dbo.Osobas", "Miejscowosc_Id", "dbo.Miejscowoscs", "Id");
        }
    }
}
