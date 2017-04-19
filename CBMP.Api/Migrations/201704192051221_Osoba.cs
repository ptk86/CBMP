namespace CBMP.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Osoba : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Osobas", "Imie", c => c.String());
            AddColumn("dbo.Osobas", "Nazwisko", c => c.String());
            AddColumn("dbo.Osobas", "MiejsceUrodzenia", c => c.String());
            AddColumn("dbo.Osobas", "KodPocztowy", c => c.String());
            AddColumn("dbo.Osobas", "Miasto", c => c.String());
            AddColumn("dbo.Osobas", "Ulica", c => c.String());
            AddColumn("dbo.Osobas", "NumerDomu", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Osobas", "NumerDomu");
            DropColumn("dbo.Osobas", "Ulica");
            DropColumn("dbo.Osobas", "Miasto");
            DropColumn("dbo.Osobas", "KodPocztowy");
            DropColumn("dbo.Osobas", "MiejsceUrodzenia");
            DropColumn("dbo.Osobas", "Nazwisko");
            DropColumn("dbo.Osobas", "Imie");
        }
    }
}
