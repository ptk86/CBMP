using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CBMP.Api.Models
{
    public class Miejscowosc
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Osoba> UrodzeoneOsoby { get; set; }
        public ICollection<Osoba> ZamieszkujaceOsoby { get; set; }

        public Miejscowosc()
        {
            UrodzeoneOsoby = new Collection<Osoba>();
            ZamieszkujaceOsoby = new Collection<Osoba>();
        }
    }
}