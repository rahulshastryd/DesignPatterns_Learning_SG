using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.CommandPattern.Classes.Models
{
    public class MenuItem
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public int TableNumber { get; set; }
        public List<Tag> Tags { get; set; }

        public void DisplayOrder()
        {
            Console.WriteLine("Table No: " + TableNumber);
            Console.WriteLine("Item: " + Item);
            Console.WriteLine("Quantity: " + Quantity);
            Console.Write("\tTags: ");
            foreach (var tag in Tags) Console.WriteLine(tag.TagName);
        }
    }
}
