using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CBMP.Api.Models;

namespace CBMP.Api.Dal
{
    public class AppContext : DbContext
    {
        public AppContext():base("CBMP")
        {
            
        }
        private DbSet<Badanie> Badania { get; set; }
    }
}