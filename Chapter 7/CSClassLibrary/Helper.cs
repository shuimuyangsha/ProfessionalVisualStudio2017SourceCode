using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClassLibrary
{
    public class Helper
    {
        public void Method()
        {
            Customer customer = new Customer();

            customer.LoadAll();
        }
    }
}
