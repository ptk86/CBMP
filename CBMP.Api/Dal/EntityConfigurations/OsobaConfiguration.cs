using System.Data.Entity.ModelConfiguration;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class OsobaConfiguration : EntityTypeConfiguration<Osoba>
    {
        public OsobaConfiguration()
        {
            ToTable("Osoby");

            HasKey(o => o.Id);

            HasRequired(o => o.Imie).WithMany(i => i.Osoby).HasForeignKey(o => o.ImieId).WillCascadeOnDelete(false);

            Property(o => o.Nazwisko).IsRequired().HasMaxLength(64);

            HasRequired(o => o.MiejsceUrodzenia).WithMany(m => m.Urodzeni).HasForeignKey(o => o.MiejsceUrodzeniaId).WillCascadeOnDelete(false);

            Property(o => o.KodPocztowy).IsRequired().HasMaxLength(8);

            HasRequired(o => o.MiejsceZamieszkania).WithMany(m => m.Zamieszkujacy).HasForeignKey(o => o.MiejsceZamieszkaniaId).WillCascadeOnDelete(false);

            Property(o => o.Ulica).IsRequired().HasMaxLength(64);

            Property(o => o.NumerDomu).IsRequired().HasMaxLength(16);
        }
    }
}