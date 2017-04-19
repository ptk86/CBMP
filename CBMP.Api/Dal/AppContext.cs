﻿using System.Data.Entity;
using CBMP.Api.Dal.EntityConfigurations;
using CBMP.Api.Models;

namespace CBMP.Api.Dal
{
    public class AppContext : DbContext
    {
        public AppContext() : base("CBMP")
        {
        }

        private DbSet<Badanie> Badania { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ImieConfiguration());
            modelBuilder.Configurations.Add(new MiejscowoscConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}