﻿using DesignPatterns.Patterns.CommandPattern.Classes.ICommand;
using DesignPatterns.Patterns.CommandPattern.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.CommandPattern.Classes.Command
{
    public class RemoveOrderCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
        {
            order.Remove(order.Where(x => x.Item == newItem.Item).First());
        }
    }
}
