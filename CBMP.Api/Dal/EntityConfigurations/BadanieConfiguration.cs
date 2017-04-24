using System.Data.Entity.ModelConfiguration;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class BadanieConfiguration : EntityTypeConfiguration<Badanie>
    {
        public BadanieConfiguration()
        {
            ToTable("Badania");

            HasKey(b => b.Id);

            Property(b => b.Data).IsRequired().HasColumnType("datetime2");

            HasRequired(b => b.Osoba).WithMany(o => o.Badania).HasForeignKey(b => b.OsobaId).WillCascadeOnDelete(false);

            HasRequired(b => b.Badajcy).WithMany(o => o.Badania).HasForeignKey(b => b.BadajacyId).WillCascadeOnDelete(false);

            HasRequired(b => b.RodzajBadania).WithMany(o => o.Badania).HasForeignKey(b => b.RodzajBadaniaId).WillCascadeOnDelete(false);

            HasRequired(b => b.Kierujacy).WithMany(o => o.Badania).HasForeignKey(b => b.KierujacyId).WillCascadeOnDelete(false);

            HasOptional(b => b.Sieciowiec).WithMany(s => s.Badania).HasForeignKey(b => b.SieciowiecId).WillCascadeOnDelete(false);

            HasRequired(b => b.Pracodawca).WithMany(o => o.Badania).HasForeignKey(b => b.PracodawcaId).WillCascadeOnDelete(false);

            HasRequired(b => b.Lokalizacja).WithMany(o => o.Badania).HasForeignKey(b => b.LokalizacjaId).WillCascadeOnDelete(false);
        }
    }
}