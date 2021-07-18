using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10
{
    public class Order : IDataErrorInfo
    {
        private Customer _customer;
        private DateTime _dateOrdered;
        private DateTime _dateShipped;
        private int _orderId;
        private OrderStatus _orderStatus;
        private double _orderTotal;

        public DateTime DateOrdered
        {
            get { return _dateOrdered; }
            set { _dateOrdered = value; }
        }

        public DateTime DateShipped
        {
            get { return _dateShipped; }
            set { _dateShipped = value; }
        }

        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public double Total
        {
            get { return _orderTotal; }
            set { _orderTotal = value; }
        }

        public event EventHandler StatusChanged;

        public string this[string columnName]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public OrderStatus OrderStatus
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Customer Customer
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
