using System;

namespace CSConsoleApp
{
    internal class Customer
    {
        public string FirstName { get; internal set; }
        public bool FullName { get; internal set; }
        public string LastName { get; internal set; }

        internal void Save()
        {
            throw new NotImplementedException();
        }

        internal void PrintGreeting(string customerName, 
            string format = "Hello {0}")
        {
            Console.WriteLine(format, customerName);
        }

        internal void PrintClosingMessage()
        {
            Console.WriteLine("Goodbye");
        }

    }
}