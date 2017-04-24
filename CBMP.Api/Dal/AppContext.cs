using System.Data.Entity;
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
            modelBuilder.Configurations.Add(new OsobaConfiguration());
            modelBuilder.Configurations.Add(new BadanieConfiguration());
            modelBuilder.Configurations.Add(new BadajacyConfiguation());
            base.OnModelCreating(modelBuilder);
        }
    }
}