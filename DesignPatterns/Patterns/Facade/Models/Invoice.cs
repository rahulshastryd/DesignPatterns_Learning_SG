using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade.Models
{
    public class Invoice
    {
        public void SendInvoice()
        {
            Console.WriteLine("Sending Invoice...\n" +
                "Invoice sent successfully!");
        }
    }
}
