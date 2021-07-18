using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10
{
    public class Customer
    {
        private string _name;
        private List<Order> _orders;

        /// <summary>
        /// Gets the unique id for ths customer
        /// </summary>
        public string CustomerId { get; set; }
        /// <summary>
        /// The display name for the customer
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
        }

        /// <summary>
        /// Adds an order to this customer
        /// </summary>
        public void AddOrder(Order o)
        {
            _orders.Add(o);
        }

        /// <summary>
        /// Constructor for the customer
        /// </summary>
        public Customer()
        {
            _orders = new List<Order>();
        }
    }
}
