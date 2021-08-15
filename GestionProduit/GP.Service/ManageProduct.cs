using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service
{
    public class ManageProduct
    {
        public Func<string, List<Product>> FindProducts;

        private ICollection<Product> products;

        public Action<Category> ScanProducts;
        public ManageProduct()
        {
            /*  FindProducts = delegate (string c)
              {
                  List<Product> list = new List<Product>();
                  foreach (Product p in products)
                  {
                      if (p.Name.StartsWith(c))
                      {
                          list.Add(p);
                      }
                  }
                  return list;
              };*/

            FindProducts = (string c) =>
            {
                List<Product> list = new List<Product>();
                foreach (Product p in products)
                {
                    if (p.Name.StartsWith(c))
                    {
                        list.Add(p);
                    }
                }
                return list;
            };

          /*  ScanProducts = delegate (Category cat)
            {
                foreach (Product p in products)
                {
                    if (p.Categorie.Name.Equals(cat.Name))
                    {
                        p.GetDetails();
                    }
                }
            };*/

            ScanProducts = (cat) =>
            {;
                foreach (Product p in products)
                {
                    if (p.Categorie.Name.Equals(cat.Name))
                    {
                        p.GetDetails();
                    }
                }
            };

        }
        public IEnumerable<Product> Get5Chemical(double price)
        {
            var Query =
                from p in products
                where p.Price > price && p is Chemical
                select p;
            return Query.Take(5); 
        }

        public IEnumerable<Product> GetProductPrice(double price)
        {
            var Query =
                from p in products
                where p.Price > price
                select p;
            return Query.Skip(2);
        }
        public double GetAveragePrice()
        {
            var Query =
                from p in products
                select p.Price;
            return Query.Average();
        }
        public Product GetMaxPrice()
        {
            var Query =
                from p in products
                select p.Price;
            var MaxPrice = Query.Max();
            var Query2 =
                from p in products
                where p.Price == MaxPrice
                select p;
            return Query2.First();
        }
        public int GetCountProduct(string city)
        {
            var Query =
              from p in products
              where p is Chemical && ((Chemical)p).adresse.City.Equals(city)
              select p;
            return Query.Count();
        }
        public IEnumerable<Product> GetChemicalCity()
        {
            var Query =
            from p in products
            where p is Chemical
            orderby ((Chemical)p).adresse.City ascending
            select p;
            return Query;
        }
        public void GetChemicalGroupByCity()
        {
            var Query =
            from p in products
            where p is Chemical
            orderby ((Chemical)p).adresse.City ascending
            group p by ((Chemical)p).adresse.City;
            foreach (var c in Query)
            {
                Console.WriteLine(c.Key);
                foreach (var p in c)
                    Console.WriteLine(p.Name);
            }
        }

    }
}
