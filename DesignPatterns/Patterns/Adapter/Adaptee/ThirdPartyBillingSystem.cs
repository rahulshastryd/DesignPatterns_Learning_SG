using DesignPatterns.Patterns.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter.Adaptee
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employeelist)
        {
            foreach (Employee employee in employeelist)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
