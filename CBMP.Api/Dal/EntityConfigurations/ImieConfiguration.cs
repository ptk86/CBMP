using System.Data.Entity.ModelConfiguration;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class ImieConfiguration : EntityTypeConfiguration<Imie>
    {
        public ImieConfiguration()
        {
            ToTable("Imiona");

            HasKey(i => i.Id);

            Property(i => i.Nazwa).IsRequired().HasMaxLength(20);
        }
    }
}