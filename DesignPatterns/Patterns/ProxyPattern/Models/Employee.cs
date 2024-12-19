using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ProxyPattern.Models
{
    public class Employee
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string  Role { get; set; }

        public Employee(string username,string password, string role)
        {
            this.UserName = username;
            this.Password = password;
            this.Role = role;
        }
    }
}
