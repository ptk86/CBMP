using System.Data.Entity.ModelConfiguration;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class SieciowiecConfiguration : EntityTypeConfiguration<Sieciowiec>
    {
        public SieciowiecConfiguration()
        {
            ToTable("Sieciowcy");

            HasKey(s => s.Id);

            Property(s => s.Nazwa).IsRequired().HasMaxLength(32);
        }
    }
}