using DesignPatterns.Patterns.Factory.AbstractFactory.Interfaces.IFormatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory.AbstractFactory.ConcreteClasses.Formatter
{
    public class TxtConverter:IDocumentConverter
    {
        public string TargetExtension => ".txt";

        public string Convert(string content)
        {
            Console.WriteLine(content);
            return content + " [Converted to TXT]";
        }
    }
}
