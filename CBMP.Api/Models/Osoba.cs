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
        public int ImieId { get; set; }
        public Imie Imie { get; set; }
        public string Nazwisko { get; set; }
        public int MiejsceUrodzeniaId { get; set; }
        public Miejscowosc MiejsceUrodzenia { get; set; }
        public string KodPocztowy { get; set; }
        public int MiejsceZamieszkaniaId { get; set; }
        public Miejscowosc MiejsceZamieszkania { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public ICollection<Badanie> Badania { get; set; }
    }
}