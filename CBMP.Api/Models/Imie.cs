using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Imie
    {
        public Imie()
        {
            Osoby = new Collection<Osoba>();
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Osoba> Osoby { get; set; }
    }
}