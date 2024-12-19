using DesignPatterns.Patterns.ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ProxyPattern.Models
{
    public class SharedFolder : ISharedFolder
    {
        public bool hasAdminRole { get; set; } = false;
        public bool CheckUserRole(string role)
        {
            if (role == "Manager" || role == "CEO")
            {
                hasAdminRole = true;
                Console.WriteLine("Granted Resource Access!!!");
                return hasAdminRole;

            }
            return hasAdminRole;
        }

        public void PerformReadWriteOperatrion()
        {
            //Some expensive operations
            Console.WriteLine("Performing the read|write operations!!!");
            Console.WriteLine("Tasks Completed Successfully!!!");
        }
    }
}
