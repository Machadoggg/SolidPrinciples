namespace SolidPrinciples.InterfaceSegregation
{
    public class BasicPrinter : IBlackAndWhitePrinter
    {
        public void PrintBlackAndWhite(string document)
        {
            Console.WriteLine($"Printing document in black and white: {document}");
        }
    }
}
