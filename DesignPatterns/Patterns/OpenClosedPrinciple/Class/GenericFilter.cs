using DesignPatterns.Patterns.OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.OpenClosedPrinciple.Class
{
    public class GenericFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if(spec.IsSatisfied(item))
                    yield return item;
            }
        }
    }
}
