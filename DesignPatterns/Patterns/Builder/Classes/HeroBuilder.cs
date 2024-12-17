using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder.Classes
{
    public class HeroBuilder
    {
        public Hero _hero = new Hero();

        public HeroBuilder SetName(string name)
        {
           _hero.Name = name;
            return this;
        }

        public HeroBuilder SetClass(string heroClass)
        {
            _hero.Class = heroClass;    
            return this;
        }

        public HeroBuilder SetHealth(int health)
        {
            _hero.Health = health;
            return this;
        }

        public HeroBuilder SetAttack(int attack)
        {
            _hero.Attack = attack;  
            return this;
        }

        public HeroBuilder SetSpecialSkill(string specialSkill)
        {
            _hero.SpecialSkill = specialSkill;
            return this;
        }
        public Hero Build()
        {
            return _hero; // Finalize and return the hero
        }
    }
}
