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
                        KierujacyId = c.Int(nullable: false),
                        PracodawdaId = c.Int(nullable: false),
                        LokalizacjaId = c.Int(nullable: false),
                        Badajcy_Id = c.Int(),
                        Osoba_Id = c.Int(),
                        Pracodawca_Id = c.Int(),
                        RodzajBadania_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Badajcies", t => t.Badajcy_Id)
                .ForeignKey("dbo.Kierujacies", t => t.KierujacyId, cascadeDelete: true)
                .ForeignKey("dbo.Lokalizacjas", t => t.LokalizacjaId, cascadeDelete: true)
                .ForeignKey("dbo.Osoby", t => t.Osoba_Id)
                .ForeignKey("dbo.Pracodawcas", t => t.Pracodawca_Id)
                .ForeignKey("dbo.RodzajBadanias", t => t.RodzajBadania_Id)
                .Index(t => t.KierujacyId)
                .Index(t => t.LokalizacjaId)
                .Index(t => t.Badajcy_Id)
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
                "dbo.Osoby",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pesel = c.String(),
                        ImieId = c.Int(nullable: false),
                        Nazwisko = c.String(nullable: false, maxLength: 64),
                        MiejsceUrodzeniaId = c.Int(nullable: false),
                        KodPocztowy = c.String(nullable: false, maxLength: 8),
                        MiejsceZamieszkaniaId = c.Int(nullable: false),
                        Ulica = c.String(nullable: false, maxLength: 64),
                        NumerDomu = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Imiona", t => t.ImieId)
                .ForeignKey("dbo.Miejscowosci", t => t.MiejsceUrodzeniaId)
                .ForeignKey("dbo.Miejscowosci", t => t.MiejsceZamieszkaniaId)
                .Index(t => t.ImieId)
                .Index(t => t.MiejsceUrodzeniaId)
                .Index(t => t.MiejsceZamieszkaniaId);
            
            CreateTable(
                "dbo.Imiona",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Miejscowosci",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false, maxLength: 20),
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
            DropForeignKey("dbo.Osoby", "MiejsceZamieszkaniaId", "dbo.Miejscowosci");
            DropForeignKey("dbo.Osoby", "MiejsceUrodzeniaId", "dbo.Miejscowosci");
            DropForeignKey("dbo.Osoby", "ImieId", "dbo.Imiona");
            DropForeignKey("dbo.Badanies", "Osoba_Id", "dbo.Osoby");
            DropForeignKey("dbo.Badanies", "LokalizacjaId", "dbo.Lokalizacjas");
            DropForeignKey("dbo.Badanies", "KierujacyId", "dbo.Kierujacies");
            DropForeignKey("dbo.Badanies", "Badajcy_Id", "dbo.Badajcies");
            DropIndex("dbo.Osoby", new[] { "MiejsceZamieszkaniaId" });
            DropIndex("dbo.Osoby", new[] { "MiejsceUrodzeniaId" });
            DropIndex("dbo.Osoby", new[] { "ImieId" });
            DropIndex("dbo.Badanies", new[] { "RodzajBadania_Id" });
            DropIndex("dbo.Badanies", new[] { "Pracodawca_Id" });
            DropIndex("dbo.Badanies", new[] { "Osoba_Id" });
            DropIndex("dbo.Badanies", new[] { "Badajcy_Id" });
            DropIndex("dbo.Badanies", new[] { "LokalizacjaId" });
            DropIndex("dbo.Badanies", new[] { "KierujacyId" });
            DropTable("dbo.RodzajBadanias");
            DropTable("dbo.Pracodawcas");
            DropTable("dbo.Miejscowosci");
            DropTable("dbo.Imiona");
            DropTable("dbo.Osoby");
            DropTable("dbo.Lokalizacjas");
            DropTable("dbo.Kierujacies");
            DropTable("dbo.Badajcies");
            DropTable("dbo.Badanies");
        }
    }
}
