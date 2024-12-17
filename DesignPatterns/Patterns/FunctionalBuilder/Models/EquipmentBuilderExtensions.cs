using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FunctionalBuilder.Models
{
    public static class EquipmentBuilderExtensions
    {
        public static EquipmentBuilder PurchaseYear(this EquipmentBuilder builder, int purchaseYear) 
        { 
            return builder.Do(p => p.PurchaseYear = purchaseYear);
        }
    }
}
