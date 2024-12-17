using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FunctionalBuilder.Models
{
    public class Equipment
    {
        public string type = string.Empty;
        public string make = string.Empty;
        public string model = string.Empty;
        public string industry = string.Empty;
        public int purchaseYear = 0;

        public string Type { get => type; set => type = value; }
        public string Make { get => make; set => type = value; }
        public string Model { get => model; set => model = value; }
        public string Industry { get => industry; set => industry = value; }
        public int PurchaseYear { get => purchaseYear; set => purchaseYear = value; }


    }
}
