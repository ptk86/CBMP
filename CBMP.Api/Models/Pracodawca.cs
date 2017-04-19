using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Pracodawca
    {
        public Pracodawca()
        {
            Badania = new Collection<Badanie>();
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Badanie> Badania { get; set; }
    }
}