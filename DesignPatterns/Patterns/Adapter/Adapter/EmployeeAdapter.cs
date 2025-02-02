using DesignPatterns.Patterns.Adapter.Adaptee;
using DesignPatterns.Patterns.Adapter.Interfaces;
using DesignPatterns.Patterns.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        public void ProcessCompanySalary(string[,] employeeList)
        {
            List<Employee> listemployee = new List<Employee>();
            ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;

            for (int i = 0; i < employeeList.GetLength(0); i++)
            {
                for (int j = 0; j < employeeList.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Id = employeeList[i,j];
                    }
                    else if(j == 1)
                    {
                        Name = employeeList[i,j];
                    }
                    else if (j == 2)
                    {
                        Designation = employeeList[i,j];
                    }
                    else
                    {
                        Salary = employeeList[i,j]; 
                    }
                }
            listemployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Salary));
            }
            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            thirdPartyBillingSystem.ProcessSalary(listemployee);
        }
    }
}
