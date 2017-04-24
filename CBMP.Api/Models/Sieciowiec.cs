using System.Collections.Generic;

namespace CBMP.Api.Models
{
    public class Sieciowiec
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Kierujacy> Kierujacy { get; set; }
    }
}