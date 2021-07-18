using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer
            {
                FirstName = "Joe",
                LastName = "Smith"
            };

            Console.WriteLine(c.FullName);
            c.Save();

            c.PrintGreeting("Mike");



















        }
    }
}
