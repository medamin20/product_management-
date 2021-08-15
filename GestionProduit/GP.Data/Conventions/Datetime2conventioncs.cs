using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Conventions
{
    public class Datetime2conventioncs : Convention
    {
        public Datetime2conventioncs()
        {
            this.Properties<DateTime>().Configure(c =>
                c.HasColumnType("datetime2"));
        }
    }
}
