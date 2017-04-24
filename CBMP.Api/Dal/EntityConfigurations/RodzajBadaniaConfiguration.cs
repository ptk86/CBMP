using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using CBMP.Api.Models;

namespace CBMP.Api.Dal.EntityConfigurations
{
    public class RodzajBadaniaConfiguration : EntityTypeConfiguration<RodzajBadania>
    {
        public RodzajBadaniaConfiguration()
        {
            ToTable("RodzajeBadan");

            HasKey(rb => rb.Id);

            Property(rb => rb.Nazwa).IsRequired().HasMaxLength(32);
        }
    }
}