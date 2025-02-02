using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade.Models
{
    public class Payment
    {
        public void MakePayment() 
        {
            Console.WriteLine("Processing....\n" +
                "Payment Successful");
        }
    }
}
