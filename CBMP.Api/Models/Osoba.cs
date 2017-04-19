using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Osoba
    {
        public Osoba()
        {
            Badania = new Collection<Badanie>();
        }

        public int Id { get; set; }
        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string MiejsceUrodzenia { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public ICollection<Badanie> Badania { get; set; }
    }
}