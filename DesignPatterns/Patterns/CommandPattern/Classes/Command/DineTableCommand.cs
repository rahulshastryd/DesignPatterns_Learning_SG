using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Patterns.CommandPattern.Classes.ICommand;

namespace DesignPatterns.Patterns.CommandPattern.Classes.Command
{
    public class DineTableCommand
    {
        public OrderCommand GetDineCommand(int dineCommand)
        {
            switch(dineCommand)
            {
                case 1:
                    return new NewOrderCommand();
                case 2:
                    return new ModifyOrderCommand();
                case 3:
                    return new RemoveOrderCommand();
                default:
                    return new NewOrderCommand();
            }
        }
    }
}
