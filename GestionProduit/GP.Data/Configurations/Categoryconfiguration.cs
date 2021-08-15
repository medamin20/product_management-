using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Configurations
{
    public class Categoryconfiguration : EntityTypeConfiguration<Category>
    {
        public Categoryconfiguration()
        {
            ToTable("Mycategories");
            HasKey(c => c.CategoryId);
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
