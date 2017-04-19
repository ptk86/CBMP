namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImieIMiejscowosc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Miejscowoscs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Osobas", "Imie_Id", c => c.Int());
            AddColumn("dbo.Osobas", "MiejsceUrodzenia_Id", c => c.Int());
            AddColumn("dbo.Osobas", "Miejscowosc_Id", c => c.Int());
            CreateIndex("dbo.Osobas", "Imie_Id");
            CreateIndex("dbo.Osobas", "MiejsceUrodzenia_Id");
            CreateIndex("dbo.Osobas", "Miejscowosc_Id");
            AddForeignKey("dbo.Osobas", "Imie_Id", "dbo.Imies", "Id");
            AddForeignKey("dbo.Osobas", "MiejsceUrodzenia_Id", "dbo.Miejscowoscs", "Id");
            AddForeignKey("dbo.Osobas", "Miejscowosc_Id", "dbo.Miejscowoscs", "Id");
            DropColumn("dbo.Osobas", "Imie");
            DropColumn("dbo.Osobas", "MiejsceUrodzenia");
            DropColumn("dbo.Osobas", "Miasto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Osobas", "Miasto", c => c.String());
            AddColumn("dbo.Osobas", "MiejsceUrodzenia", c => c.String());
            AddColumn("dbo.Osobas", "Imie", c => c.String());
            DropForeignKey("dbo.Osobas", "Miejscowosc_Id", "dbo.Miejscowoscs");
            DropForeignKey("dbo.Osobas", "MiejsceUrodzenia_Id", "dbo.Miejscowoscs");
            DropForeignKey("dbo.Osobas", "Imie_Id", "dbo.Imies");
            DropIndex("dbo.Osobas", new[] { "Miejscowosc_Id" });
            DropIndex("dbo.Osobas", new[] { "MiejsceUrodzenia_Id" });
            DropIndex("dbo.Osobas", new[] { "Imie_Id" });
            DropColumn("dbo.Osobas", "Miejscowosc_Id");
            DropColumn("dbo.Osobas", "MiejsceUrodzenia_Id");
            DropColumn("dbo.Osobas", "Imie_Id");
            DropTable("dbo.Miejscowoscs");
            DropTable("dbo.Imies");
        }
    }
}
