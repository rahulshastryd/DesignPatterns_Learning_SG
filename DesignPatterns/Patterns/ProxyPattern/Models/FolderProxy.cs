using DesignPatterns.Patterns.ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ProxyPattern.Models
{
    public class FolderProxy : ISharedFolder
    {
        public ISharedFolder folder;
        public bool hasAdminRole { get; set; } = false;
        private Employee employee;
        public FolderProxy(Employee emp)
        {
            employee = emp;
        }
        public bool CheckUserRole(string role)
        {
            if (role == "Manager" || role == "CEO")
            {
                Console.WriteLine("User has Admin Privilages...Redirecting!!!");
                folder = new SharedFolder();
                hasAdminRole =  folder.CheckUserRole(role);
                return hasAdminRole; 
            }
            return false;
        }

        public void PerformReadWriteOperatrion()
        {
            hasAdminRole = CheckUserRole(employee.Role);
            if (hasAdminRole)
            {
                //folder = new SharedFolder();
                Console.WriteLine("The user can now perform readwrite operations to the requested resources");
                Console.WriteLine("Forwarding the request.....");
                folder.PerformReadWriteOperatrion();
            }
            else
            {
                Console.WriteLine("The access is denied for the requested resource");
            }
        }
    }
}
