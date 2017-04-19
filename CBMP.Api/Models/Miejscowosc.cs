using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Miejscowosc
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Osoba> Osoby { get; set; }

        public Miejscowosc()
        {
            Osoby = new Collection<Osoba>();
        }
    }
}