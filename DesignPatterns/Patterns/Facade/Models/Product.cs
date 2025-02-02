using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade.Models
{
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching Product Details");
        }
    }
}
