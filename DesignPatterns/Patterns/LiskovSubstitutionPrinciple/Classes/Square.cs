using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.LiskovSubstitutionPrinciple.Classes
{
    public class Square:Rectangle
    {
        public override double width 
        {
            set
            {
                base.width = base.width = value;
            }
        }
        public override double height 
        {
            set 
            {
                base.width = base.height = value;
            } 
            
        }
    }
}
