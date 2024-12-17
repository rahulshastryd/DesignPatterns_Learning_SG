using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.LiskovSubstitutionPrinciple.Classes
{
    public class Rectangle
    {
        public virtual double height { get; set; }
        public virtual double width { get; set; }
        public Rectangle()
        {
            
        }
        public Rectangle(double height,double width)
        {
            this.height = height;
            this.width = width;
        }

        public override string ToString()
        {
            return $"{nameof(width)}: {width}, {nameof(height)}: {height}";
        }


        public virtual double area()
        {
            return height * width;
        }

    }
}
