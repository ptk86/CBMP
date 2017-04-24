using System.Data.Entity.ModelConfiguration;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class MiejscowoscConfiguration : EntityTypeConfiguration<Miejscowosc>
    {
        public MiejscowoscConfiguration()
        {
            ToTable("Miejscowosci");

            HasKey(i => i.Id);

            Property(i => i.Nazwa).IsRequired().HasMaxLength(32);
        }
    }
}