using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Chemical : Product
    {
       // public string City { get; set; }
        public string LabName { get; set; }
       // public string StreetAdress { get; set; }

        public Adress adresse { get; set; }

        public override void GetMyType()
        {
            System.Console.WriteLine("Chimecal");
        }
    }


}
