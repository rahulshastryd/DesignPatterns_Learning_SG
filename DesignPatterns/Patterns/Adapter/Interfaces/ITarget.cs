using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter.Interfaces
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] companySalary);
    }
}
