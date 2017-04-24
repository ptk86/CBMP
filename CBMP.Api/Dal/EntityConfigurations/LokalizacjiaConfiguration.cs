using System.Data.Entity.ModelConfiguration;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class LokalizacjaConfiguration : EntityTypeConfiguration<Lokalizacja>
    {
        public LokalizacjaConfiguration()
        {
            ToTable("Lokalizacje");

            HasKey(s => s.Id);

            Property(s => s.Nazwa).IsRequired().HasMaxLength(32);
        }
    }
}