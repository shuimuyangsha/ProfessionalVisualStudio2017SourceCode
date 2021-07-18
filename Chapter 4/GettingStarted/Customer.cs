using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettingStarted
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public string CompanyName { get; set; }
		public string City {get; set; }
        public List<Order> Orders { get; set; }
    }

}
