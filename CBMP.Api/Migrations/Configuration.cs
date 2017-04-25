using System.Data.Entity.Migrations;
using CBMP.Api.Dal;
using CBMP.Api.Models;

namespace CBMP.Api.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppContext context)
        {
            var imie = new Imie { Nazwa = "Piotr" };
            var imie2 = new Imie { Nazwa = "Micha³" };
            var imie3 = new Imie { Nazwa = "Tomasz" };

            context.Imiona.Add(imie);
            context.Imiona.Add(imie2);
            context.Imiona.Add(imie3);

            var miejscowosc = new Miejscowosc { Nazwa = "Czêstochowa" };
            var miejscowosc2 = new Miejscowosc { Nazwa = "K³obuck" };

            context.Miejscowosci.Add(miejscowosc);
            context.Miejscowosci.Add(miejscowosc2);

            var osoba = new Osoba
            {
                Pesel = "86030403770",
                Imie = imie,
                Nazwisko = "Kiliñski",
                KodPocztowy = "42-200",
                MiejsceZamieszkania = miejscowosc,
                Ulica = "Irzykowskiego",
                NumerDomu = "3/24",
                MiejsceUrodzenia = miejscowosc
            };

            context.Osoby.Add(osoba);

            base.Seed(context);
            context.SaveChanges();
        }
    }
}