namespace SolidPrinciples.InterfaceSegregation
{
    public interface IPrinter
    {
        void PrintBlackAndWhite(string document);
        void PrintColor(string document);
        void ScanDocument(string document);
    }
}
