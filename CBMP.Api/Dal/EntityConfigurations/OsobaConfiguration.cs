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

            HasRequired(o => o.Imie);
        }
    }
}