namespace CBMP.Api.Dtos
{
    public class OsobaDto
    {
        public int Id { get; set; }
        public string Pesel { get; set; }
        public int ImieId { get; set; }
        public string Nazwisko { get; set; }
        public int MiejsceUrodzeniaId { get; set; }
        public string KodPocztowy { get; set; }
        public int MiejsceZamieszkaniaId { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
    }
}