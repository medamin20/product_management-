using GP.Data.Configurations;
using GP.Data.Conventions;
using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data
{
   public class GPContext: DbContext 
    {
        public GPContext():base("name =GPConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Categoryconfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Conventions.Add(new Datetime2conventioncs());



        }


    }
}
