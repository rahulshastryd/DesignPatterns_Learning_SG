using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Salary { get; set; }

        public Employee(int Id,string Name,string Designation,string Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Designation = Designation;
            this.Salary = Salary;
        }
    }
}
