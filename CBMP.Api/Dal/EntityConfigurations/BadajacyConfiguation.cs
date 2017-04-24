using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class BadajacyConfiguation : EntityTypeConfiguration<Badajcy>
    {
        public BadajacyConfiguation()
        {
            ToTable("Badajacy");

            HasKey(b => b.Id);

            Property(b => b.Nazwisko).IsRequired().HasMaxLength(32);

            Property(b => b.Imie).IsRequired().HasMaxLength(32);

            Ignore(b => b.Skrot);
        }
    }
}