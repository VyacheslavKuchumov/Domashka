using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> ikeaCustomers = new HashSet<string>();
            ikeaCustomers.Add("Ivan");
            ikeaCustomers.Add("Boris");
            ikeaCustomers.Add("Marie");

            HashSet<string> domadomCustomers = new HashSet<string>();
            domadomCustomers.Add("Vlad");

            HashSet<string> mebelruCustomers = new HashSet<string>();
            mebelruCustomers.Add("Ivan");
            mebelruCustomers.Add("Boris");

            HashSet<string> zarahomeCustomers = new HashSet<string>();
            zarahomeCustomers.Add("Ivan");
            zarahomeCustomers.Add("Boris");
            zarahomeCustomers.Add("Marie");
            if (ikeaCustomers.Overlaps(zarahomeCustomers))
            {
                Console.WriteLine("There are same customers in ikea and zara");
            }
            else
            {
                Console.WriteLine("no same customers");
            }
            if (ikeaCustomers.Overlaps(domadomCustomers))
            {
                Console.WriteLine("There are same customers");
            }
            else
            {
                Console.WriteLine("all customers are different in ikea and domadom");
            }

        }
    }
}          
    
   


