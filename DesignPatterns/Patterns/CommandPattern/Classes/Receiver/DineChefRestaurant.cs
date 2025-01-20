using DesignPatterns.Patterns.CommandPattern.Classes.ICommand;
using DesignPatterns.Patterns.CommandPattern.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.CommandPattern.Classes.Receiver
{
    public class DineChefRestaurant
    {
        public List<MenuItem> Orders { get; set; }

        public DineChefRestaurant()
        {
            Orders = new List<MenuItem>();
        }

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(Orders, item);
        }

        public void ShowOrders()
        {
            foreach (var item in Orders)
            {
                item.DisplayOrder();
            }
        }
    }
}
