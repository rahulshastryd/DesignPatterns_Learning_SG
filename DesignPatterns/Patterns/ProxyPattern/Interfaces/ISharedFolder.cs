using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ProxyPattern.Interfaces
{
    public interface ISharedFolder
    {
        bool CheckUserRole(string role);
        void PerformReadWriteOperatrion();
    }
}
