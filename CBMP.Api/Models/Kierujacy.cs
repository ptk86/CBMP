using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Kierujacy
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public bool CzyMedycynaPracy { get; set; }
        public Sieciowiec Sieciowiec { get; set; }
        public ICollection<Badanie> Badania { get; set; }
        public Kierujacy()
        {
            Badania = new Collection<Badanie>();
        }

    }
}