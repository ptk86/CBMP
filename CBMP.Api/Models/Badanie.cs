using System;

namespace CBMP.Api.Models
{
    public class Badanie
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdOsoba { get; set; }
        public Osoba Osoba { get; set; }
        public int IdBadajacy{ get; set; }
        public Badajcy Badajcy { get; set; }
        public int IdRodzajBadania { get; set; }
        public RodzajBadania RodzajBadania { get; set; }
        public int IdKierujacy { get; set; }
        public Kierujacy Kierujacy { get; set; }
        public int IdPracodawda { get; set; }
        public Pracodawca Pracodawca { get; set; }
        public int IdLokalizacja { get; set; }
        public Lokalizacja Lokalizacja { get; set; }
    }
}