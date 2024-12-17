using DesignPatterns.Patterns.OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.OpenClosedPrinciple.Class
{
    public class AndSpecification<T>: ISpecification<T>
    {
        private ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first , ISpecification<T> second)
        {
            if (first == null) throw new ArgumentNullException(paramName:nameof(second));

            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second;
        }
        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}
