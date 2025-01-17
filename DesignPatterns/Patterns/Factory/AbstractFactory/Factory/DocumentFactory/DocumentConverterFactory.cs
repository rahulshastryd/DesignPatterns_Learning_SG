using DesignPatterns.Patterns.Factory.AbstractFactory.ConcreteClasses.Formatter;
using DesignPatterns.Patterns.Factory.AbstractFactory.Interfaces.IFormatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory.AbstractFactory.Factory.DocumentFactory
{
    public static class DocumentConverterFactory
    {
        public static IDocumentConverter CreateDocumentConverter(string documentType)
        {
            switch (documentType.ToLower())
            {
                case "docx":
                    return new DocxConverter();
                case "pdf":
                    return new PdfConverter();
                case "txt":
                    return new TxtConverter();
                default:
                    return null;

            }
        }
    }
}
