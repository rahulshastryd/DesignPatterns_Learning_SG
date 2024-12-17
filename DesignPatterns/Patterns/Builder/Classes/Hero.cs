using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder.Classes
{
    public class Hero
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public string SpecialSkill { get; set; }

        public override string ToString()
        {
            return $"Hero: {Name}, Class: {Class}, HP: {Health}, Attack: {Attack}, Skill: {SpecialSkill}";
        }
    }
}
