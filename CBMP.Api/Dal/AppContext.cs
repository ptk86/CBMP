using System.Data.Entity;
using CBMP.Api.Models;

namespace CBMP.Api.Dal
{
    public class AppContext : DbContext
    {
        public AppContext() : base("CBMP")
        {
        }

        private DbSet<Badanie> Badania { get; set; }
    }
}