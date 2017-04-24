using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class PracodawcaConfiguration : EntityTypeConfiguration<Pracodawca>
    {
        public PracodawcaConfiguration()
        {
            ToTable("Pracodawcy");

            HasKey(p => p.Id);

            Property(p => p.Nazwa).IsRequired().HasMaxLength(32);
        }
    }
}