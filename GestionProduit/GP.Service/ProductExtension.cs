using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service
{
    public static class ProductExtension
    {
        public static void UpperName(this ManageProduct ManageProduct, Product p)
        {
            p.Name = p.Name.ToUpper();
        }
        public static bool InCategory(this ManageProduct ManageProduct, Product p, Category c)
        {
           return p.Categorie.Name == c.Name;
        }
    }
}
