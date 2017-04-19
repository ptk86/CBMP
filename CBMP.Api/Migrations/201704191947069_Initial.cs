namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Badanies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        IdOsoba = c.Int(nullable: false),
                        IdBadajacy = c.Int(nullable: false),
                        IdRodzajBadania = c.Int(nullable: false),
                        IdKierujacy = c.Int(nullable: false),
                        IdPracodawda = c.Int(nullable: false),
                        IdLokalizacja = c.Int(nullable: false),
                        Badajcy_Id = c.Int(),
                        Kierujacy_Id = c.Int(),
                        Lokalizacja_Id = c.Int(),
                        Osoba_Id = c.Int(),
                        Pracodawca_Id = c.Int(),
                        RodzajBadania_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Badajcies", t => t.Badajcy_Id)
                .ForeignKey("dbo.Kierujacies", t => t.Kierujacy_Id)
                .ForeignKey("dbo.Lokalizacjas", t => t.Lokalizacja_Id)
                .ForeignKey("dbo.Osobas", t => t.Osoba_Id)
                .ForeignKey("dbo.Pracodawcas", t => t.Pracodawca_Id)
                .ForeignKey("dbo.RodzajBadanias", t => t.RodzajBadania_Id)
                .Index(t => t.Badajcy_Id)
                .Index(t => t.Kierujacy_Id)
                .Index(t => t.Lokalizacja_Id)
                .Index(t => t.Osoba_Id)
                .Index(t => t.Pracodawca_Id)
                .Index(t => t.RodzajBadania_Id);
            
            CreateTable(
                "dbo.Badajcies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kierujacies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        CzyMedycynaPracy = c.Boolean(nullable: false),
                        Sieciowiec = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lokalizacjas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Osobas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pesel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pracodawcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RodzajBadanias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Badanies", "RodzajBadania_Id", "dbo.RodzajBadanias");
            DropForeignKey("dbo.Badanies", "Pracodawca_Id", "dbo.Pracodawcas");
            DropForeignKey("dbo.Badanies", "Osoba_Id", "dbo.Osobas");
            DropForeignKey("dbo.Badanies", "Lokalizacja_Id", "dbo.Lokalizacjas");
            DropForeignKey("dbo.Badanies", "Kierujacy_Id", "dbo.Kierujacies");
            DropForeignKey("dbo.Badanies", "Badajcy_Id", "dbo.Badajcies");
            DropIndex("dbo.Badanies", new[] { "RodzajBadania_Id" });
            DropIndex("dbo.Badanies", new[] { "Pracodawca_Id" });
            DropIndex("dbo.Badanies", new[] { "Osoba_Id" });
            DropIndex("dbo.Badanies", new[] { "Lokalizacja_Id" });
            DropIndex("dbo.Badanies", new[] { "Kierujacy_Id" });
            DropIndex("dbo.Badanies", new[] { "Badajcy_Id" });
            DropTable("dbo.RodzajBadanias");
            DropTable("dbo.Pracodawcas");
            DropTable("dbo.Osobas");
            DropTable("dbo.Lokalizacjas");
            DropTable("dbo.Kierujacies");
            DropTable("dbo.Badajcies");
            DropTable("dbo.Badanies");
        }
    }
}
