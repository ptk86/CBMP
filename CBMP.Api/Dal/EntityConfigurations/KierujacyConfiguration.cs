using System.Data.Entity.ModelConfiguration;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class KierujacyConfiguration : EntityTypeConfiguration<Kierujacy>
    {
        public KierujacyConfiguration()
        {
            ToTable("Kierujacy");

            HasKey(k => k.Id);

            Property(k => k.Nazwa).IsRequired().HasMaxLength(32);
        }
    }
}