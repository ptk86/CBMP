using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Miejscowosc
    {
        public Miejscowosc()
        {
            Urodzeni = new Collection<Osoba>();
            Zamieszkujacy = new Collection<Osoba>();
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Osoba> Urodzeni { get; set; }
        public ICollection<Osoba> Zamieszkujacy { get; set; }
    }
}