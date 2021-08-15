using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasMany(p => p.Providers).WithMany(prov => prov.Products).Map(m =>
            {
                m.ToTable("Providings");   //Table d'association
                m.MapLeftKey("Product");
                m.MapRightKey("Provider");
            });

            HasRequired(p => p.Categorie).WithMany(Cat => Cat.Products).HasForeignKey(p => p.categoryId).WillCascadeOnDelete(false);

        }
        
    }
}
