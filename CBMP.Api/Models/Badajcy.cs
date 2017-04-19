using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Badajcy
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Badanie> Badania { get; set; }
        public Badajcy()
        {
            Badania = new Collection<Badanie>();
        }
    }
}