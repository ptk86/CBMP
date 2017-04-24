using System.Collections.Generic;

namespace CBMP.Api.Models
{
    public class Sieciowiec
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Badanie> Badania { get; set; }
    }
}