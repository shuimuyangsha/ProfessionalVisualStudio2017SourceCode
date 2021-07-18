using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_10
{
    public abstract class Product
    {
        public abstract string Description
        {
            get;

            set;
        }

        public abstract double Price
        {
            get;

            set;
        }

        public abstract string SKU
        {
            get;

            set;
        }

        public void GetInventory()
        {
            throw new System.NotImplementedException();
        }
    }
}