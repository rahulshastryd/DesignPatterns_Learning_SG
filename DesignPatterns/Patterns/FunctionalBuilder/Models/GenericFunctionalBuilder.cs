using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FunctionalBuilder.Models
{
    public abstract class GenericFunctionalBuilder<TSubject,TSelf>
        where TSubject : new()
        where TSelf : GenericFunctionalBuilder<TSubject,TSelf>
    {
        private readonly List<Func<TSubject,TSubject>> actions = new List<Func<TSubject, TSubject>>();

        public TSelf Do(Action<TSubject> action)
        {
            AddActions(action);
            return (TSelf)this;
        }

        private TSelf AddActions(Action<TSubject> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });
            return (TSelf)this;
        }

        public TSubject Build()
        {
            return actions.Aggregate(new TSubject(), (p, f) => f(p));
        }
    }
}
