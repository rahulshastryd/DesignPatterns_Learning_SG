using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FluentBuilder.Classes
{
    public class WeaponBuilder
    {
        private Weapon _weapon = new Weapon();

        public WeaponBuilder SetName(string name)
        {
            _weapon.Name = name;
            return this; // Return the builder for chaining
        }

        public WeaponBuilder SetDamage(int damage)
        {
            _weapon.Damage = damage;
            return this;
        }

        public WeaponBuilder SetRange(int range)
        {
            _weapon.Range = range;
            return this;
        }

        public WeaponBuilder SetElement(string element)
        {
            _weapon.Element = element;
            return this;
        }

        public Weapon Build()
        {
            return _weapon; // Return the completed Weapon object
        }
    }

}
