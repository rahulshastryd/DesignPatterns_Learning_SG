using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FluentBuilder.Classes
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public string Element { get; set; }

        public override string ToString()
        {
            return $"Weapon: {Name}, Damage: {Damage}, Range: {Range}, Element: {Element}";
        }
    }
}
