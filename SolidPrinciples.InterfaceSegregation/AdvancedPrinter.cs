using System.Reflection.Metadata;

namespace SolidPrinciples.InterfaceSegregation
{
    public class AdvancedPrinter : IBlackAndWhitePrinter, IColorPrinter, IScanner
    {
        public void PrintBlackAndWhite(string document)
        {
            Console.WriteLine($"Printing document in black and white: {document}");
        }

        public void PrintColor(string document)
        {
            Console.WriteLine($"Printing document in color: {document}");
        }

        public void ScanDocument(string document)
        {
            Console.WriteLine($"Scanning document: {document}");
        }
    }
}
