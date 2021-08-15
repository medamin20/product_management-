using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service
{
    public class ManageProvider
    {
        private ICollection<Provider> providers;
        public IEnumerable<Provider> GetProviderByName(string name)
        {
            var Query =
            from p in providers
            where p.UserName.Contains(name)
            select p;
            return Query;
        }
        public Provider GetFirstProviderByName(string name)
        {
            var Query =
            from p in providers
            where p.UserName.Contains(name)
            select p;
            return Query.First();
        }

        public Provider GetProviderById(int id)
        {
            var Query =
            from p in providers
            where p.Id == id
            select p;
            return Query.SingleOrDefault();
        }
    }
}
