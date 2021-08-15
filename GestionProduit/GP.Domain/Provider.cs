using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider : Concept
    {
            
        private string confirmPassword;


        [Required]
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set {
                if (value == password)
                    ConfirmPassword = value;
                else Console.WriteLine("Les deux mdps saisies ne sont pas similaires");
            }
        }

        public DateTime DateCreated { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Key()] //Optional
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        private string password { get; set; }
        private int myVar;





        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required]
        public string Password
        {
            get { return password; }
    set {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else Console.WriteLine("Mot de pass incorrect");
        }
        }

        public string UserName { get; set; }
        public ICollection<Product> Products { get; set; }

        public override void GetDetails()
        {
            // throw new NotImplementedException();
            System.Console.WriteLine("Provider créé le " + DateCreated);
            if (Products != null)
                foreach (Product p in Products)
                    p.GetDetails();
        }

        public void GetProducts(string filterType, string filterValue)
        {
            if (Products != null)
                switch (filterType)
                {
                    case "Name": foreach (Product p in Products)
                            if (string.Equals(p.Name, filterValue))
                                p.GetDetails();
                        break;
                    case "DateProd":
                        foreach (Product p in Products)
                            if (DateTime.Equals(p.DateProd , DateTime.Parse(filterValue)))
                                p.GetDetails();
                        break;
                    case "Price":
                        foreach (Product p in Products)
                            if ((p.Price == double.Parse(filterValue)))
                                p.GetDetails();
                        break;

                }
                   
        }

        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = (string.Compare(P.Password, P.ConfirmPassword) == 0);
        }

        public static void SetIsApproved(string password, string confirmPassword, bool isApproved)
        {
            isApproved = (string.Compare(password, confirmPassword) == 0);
        }

        public bool Login(string userName, string password)
        {
            /*  if ((string.Compare(UserName, userName) == 0) && (string.Compare(Password, password) == 0))
                  return true;
              else
                  return false;*/

            return ((string.Compare(UserName, userName) == 0) && (string.Compare(Password, password) == 0));
        }
        public bool Login(string userName, string password,string email)
        {
            return ((string.Compare(UserName, userName) == 0) && (string.Compare(Password, password) == 0)
                && (string.Compare(Email, email) == 0));
        }

        public bool Login3(string userName, string password, string email = null)
        {
            return string.Compare(UserName, userName) == 0
                            && string.Compare(Password, password) == 0
                            && email != null ? string.Compare(Email, email) == 0 : true;
        }
    }

}
