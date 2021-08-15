using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Product : Concept
    {
        public DateTime DateProd { get; set; }
        [DataType(DataType.Date)]
        public string Description { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage="Name is Required")] 
        [StringLength (50)]
        [MaxLength(25)]
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
       // [ForeignKey("Category")]
        public int? categoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Categorie { get; set; }
        public ICollection<Provider> Providers { get; set; }
        public string image { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Le nom de produit est : " + Name + "Le prix de produit est :" + Price);
            //throw new NotImplementedException();
        }

        public virtual void GetMyType()
        {
            System.Console.WriteLine("UNKNOWN");
        }
    }
}
