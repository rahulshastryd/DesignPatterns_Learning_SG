using DesignPatterns.Patterns.CommandPattern.Classes.Command;
using DesignPatterns.Patterns.CommandPattern.Classes.ICommand;
using DesignPatterns.Patterns.CommandPattern.Classes.Models;
using DesignPatterns.Patterns.CommandPattern.Classes.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.CommandPattern.Classes.Invoker
{
    public class DineChef
    {
        private DineChefRestaurant order;
        private OrderCommand orderCommand;
        private MenuItem menuItem;

        public DineChef()
        {
            order = new DineChefRestaurant();
        }

        public void SetOrderCommand(int dineCommand)
        {
            orderCommand = new DineTableCommand().GetDineCommand(dineCommand);
        }

        public void SetMenuItem(MenuItem menuItem)
        {
            this.menuItem = menuItem;
        }

        public void ExecuteCommand()
        {
            order.ExecuteCommand(orderCommand,menuItem);
        }

        public void ShowCurrentOrder()
        {
            order.ShowOrders();
        }

    }
}
