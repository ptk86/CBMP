using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Imie
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Osoba> Osoby { get; set; }

        public Imie()
        {
            Osoby = new Collection<Osoba>();
        }

    }
}