using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FunctionalBuilder.Models
{
    public sealed class EquipmentBuilder:GenericFunctionalBuilder<Equipment,EquipmentBuilder>
    {
        public EquipmentBuilder Industry(string industry)
        {
            return Do(e=>e.Industry =  industry);
        }

        public EquipmentBuilder EquipmentModel(string model)
        {
            return Do(m=>m.Model = model);
        }
        public EquipmentBuilder EquipmentType(string type)
        {
            return Do(t=>t.Type = type);
        }
        public EquipmentBuilder EquipmentMake(string make)
        {
            return Do(mk => mk.Make = make);
        }

    }
}
