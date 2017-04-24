using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CBMP.Api.Models
{
    public class Badajcy
    {
        public Badajcy()
        {
            Badania = new Collection<Badanie>();
        }

        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Skrot => String.Empty + Imie.First() + Nazwisko.First();
        public ICollection<Badanie> Badania { get; set; }
    }
}