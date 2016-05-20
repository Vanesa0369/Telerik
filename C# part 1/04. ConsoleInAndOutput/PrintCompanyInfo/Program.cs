using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyNumber = Console.ReadLine();
            string companyFax = Console.ReadLine();
            string companySite = Console.ReadLine();
            string companyManager = Console.ReadLine();
            string managerName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerNumber = Console.ReadLine();
            if (companyFax.CompareTo(string.Empty) == 0)
            {
                companyFax = "(no fax)";
            }
            
            Console.WriteLine("Company name: {0}" , companyName);
            Console.WriteLine("Company address: {0}", companyAddress);
            Console.WriteLine("Phone number: {0}", companyNumber);
            Console.WriteLine("Fax number: {0}", companyFax);
            Console.WriteLine("Web site: {0}", companySite);
            Console.WriteLine("Manager first name: {0}", companyManager);
            Console.Write("Manager last name: {0} {1}", managerName, managerLastName);
            
            Console.WriteLine("Manager age: {0}", managerAge);
            Console.WriteLine("Manager phone: {0}", managerNumber);
        }
    }
}
