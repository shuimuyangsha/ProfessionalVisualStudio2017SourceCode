using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSWebApp
{
    public class EmployeeManager
    {
        public List<Employee> GetEmployees()
        {
            var result = new List<Employee>();
            result.Add(new Employee()
            {
                Name = "Vanessa Johnson",
                Alias = "AnnaD",
                Id = 1
            });

            return result;
        }
    }
}