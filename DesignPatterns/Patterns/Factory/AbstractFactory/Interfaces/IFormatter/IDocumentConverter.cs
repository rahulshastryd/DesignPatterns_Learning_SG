using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory.AbstractFactory.Interfaces.IFormatter
{
    public interface IDocumentConverter
    {
        string Convert(string content);
        string TargetExtension { get; }
    }
}
