using DesignPatterns.Patterns.CommandPattern.Classes.ICommand;
using DesignPatterns.Patterns.CommandPattern.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.CommandPattern.Classes.Command
{
    public class ModifyOrderCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
        {
            var item = order.Where(x => x.Item == newItem.Item).First();
            item.Item = newItem.Item;
            item.Quantity = newItem.Quantity;
            item.Tags = newItem.Tags;
            item.TableNumber = newItem.TableNumber;
        }
    }
}
