using GP.Data;
using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Provider P1 = new Provider();
            P1.Password = "123";
            P1.ConfirmPassword = "12346";

            Provider P2 = new Provider()
            {
                Password = "1234",
                ConfirmPassword = "1345"
            };

            //System.Console.WriteLine("La valeur initiale de IsApproved est " + P1.IsApproved);
            //Provider.SetIsApproved(P1);
            //System.Console.WriteLine("La nouvelle valeur de IsApproved est " + P1.IsApproved);

            System.Console.WriteLine("Valeur initiale de IsApproved :  " + P1.IsApproved);
            Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, P1.IsApproved);
            System.Console.WriteLine("Nouvelle valeur de IsApproved : " + P1.IsApproved);

            Category Cat1 = new Category
            {
                Name = "Cat1",
            };
            Category Cat2 = new Category
            {
                Name = "Cat2",
            };
            Category Cat3 = new Category
            {
                Name = "Cat3",
            };
            Provider Prov1 = new Provider
            {
                UserName = "Prov1"
            };
            Provider Prov2 = new Provider
            {
                UserName = "Prov2"
            };
            Provider Prov3 = new Provider
            {
                UserName = "Prov3"
            };
            Provider Prov4 = new Provider
            {
                UserName = "Prov4"
            };
            Provider Prov5 = new Provider
            {
                UserName = "Prov5"
            };

            Product Prod1 = new Product
            {

                Name = "Prod1",
                Price = 100,
                Categorie = Cat1,
                Providers = new List<Provider>
                {
                    Prov1,
                    Prov2,
                    Prov3
                }
            };
            Product Prod2 = new Product
            {
                Name = "Prod2",
                Price = 10,
                Categorie = Cat1,
                Providers = new List<Provider>
                {
                    Prov1,
                }
            };
            Product Prod3 = new Product
            {
                Name = "Prod3",
                Price = 200,
                Categorie = Cat3,
                 Providers = new List<Provider>
                {
                    Prov1,
                }
            };
            Product Prod4 = new Product
            {
                Name = "Prod4",
                Price = 650,
                Providers = new List<Provider>
                {
                    Prov3,
                    Prov4,
                    Prov5,
                }
            };
            Product Prod5 = new Product
            {
                Name = "Prod5",
                Price = 400,
                Categorie = Cat2,
                 Providers = new List<Provider>
                {
                    Prov2,
                }
            };
            Product Prod6 = new Product
            {
                Name = "Prod6",
                Price = 100,
                Categorie = Cat3,
                 Providers = new List<Provider>
                {
                    Prov4,
                    Prov5,
                }
            };
            Cat1.Products = new List<Product>
            {
                Prod1,
                Prod2
            };
            Cat2.Products = new List<Product>
            {
                Prod5
            };
            Cat3.Products = new List<Product>
            {
                Prod3,
                Prod6
            };
            Prov1.Products = new List<Product>
            {
                Prod1,
                Prod2,
                Prod3
            };
            Prov2.Products = new List<Product>
            {
                Prod1,
                Prod5
            };
            Prov3.Products = new List<Product>
            {
                Prod1,
                Prod4
            };
            Prov4.Products = new List<Product>
            {
                Prod6,
                Prod4,
            };
            Prov5.Products = new List<Product>
            {
                Prod6,
                Prod4,
            };*/
            GPContext GpC = new GPContext();
            Category c1 = new Category()
            {
                Name = "cat1"
            };

            GpC.Categories.Add(c1);
            GpC.SaveChanges();
            System.Console.WriteLine("Db Created");
            System.Console.ReadKey();
        }
    }
}
