using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSConsoleApp
{
    class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        internal void Save()
        {
            throw new NotImplementedException();
        }

        public string FullName { get; set; }

        public void PrintGreeting(string customerName, 
            string format = "Hello {0}")
        {
            Console.WriteLine(format, customerName);
        }

        public void PrintClosingMessage()
        {
            Console.WriteLine("Goodbye");
        }

    
    
    }
}
