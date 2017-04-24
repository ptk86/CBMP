using System.Data.Entity;
using CBMP.Api.Dal.EntityConfigurations;
using CBMP.Api.Migrations;
using CBMP.Api.Models;
using BadanieConfiguration = CBMP.Api.Dal.EntityConfigurations.BadanieConfiguration;
using KierujacyConfiguration = CBMP.Api.Dal.EntityConfigurations.KierujacyConfiguration;
using RodzajBadaniaConfiguration = CBMP.Api.Dal.EntityConfigurations.RodzajBadaniaConfiguration;
using SieciowiecConfiguration = CBMP.Api.Dal.EntityConfigurations.SieciowiecConfiguration;
using PracodawcaConfiguration = CBMP.Api.Dal.EntityConfigurations.PracodawcaConfiguration;
using LokalizacjaConfiguration = CBMP.Api.Dal.EntityConfigurations.LokalizacjaConfiguration;


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
            modelBuilder.Configurations.Add(new OsobaConfiguration());
            modelBuilder.Configurations.Add(new BadanieConfiguration());
            modelBuilder.Configurations.Add(new BadajacyConfiguation());
            modelBuilder.Configurations.Add(new RodzajBadaniaConfiguration());
            modelBuilder.Configurations.Add(new KierujacyConfiguration());
            modelBuilder.Configurations.Add(new SieciowiecConfiguration());
            modelBuilder.Configurations.Add(new PracodawcaConfiguration());
            modelBuilder.Configurations.Add(new LokalizacjaConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}