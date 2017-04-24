using System;

namespace CBMP.Api.Models
{
    public class Badanie
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int OsobaId { get; set; }
        public Osoba Osoba { get; set; }
        public int BadajacyId { get; set; }
        public Badajcy Badajcy { get; set; }
        public int RodzajBadaniaId { get; set; }
        public RodzajBadania RodzajBadania { get; set; }
        public int KierujacyId { get; set; }
        public Kierujacy Kierujacy { get; set; }
        public int? SieciowiecId { get; set; }
        public Sieciowiec Sieciowiec { get; set; }
        public int PracodawcaId { get; set; }
        public Pracodawca Pracodawca { get; set; }
        public int LokalizacjaId { get; set; }
        public Lokalizacja Lokalizacja { get; set; }
    }
}