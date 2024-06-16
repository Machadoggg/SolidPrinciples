
using SolidPrinciples.InterfaceSegregation;

IBlackAndWhitePrinter basiPrinter = new BasicPrinter();
IBlackAndWhitePrinter advancedPrinterBlackAndWhite = new AdvancedPrinter();
IColorPrinter advancedPrintColor = new AdvancedPrinter();
IScanner advancedPrinterScanner = new AdvancedPrinter();


Console.WriteLine("Using Basic printer: ");
basiPrinter.PrintBlackAndWhite("Basic document");

Console.WriteLine("\nUsing advanced printer for black and white: ");
advancedPrinterBlackAndWhite.PrintBlackAndWhite("Advanced document black and white");

Console.WriteLine("\nUsing advanced printer for color: ");
advancedPrintColor.PrintColor("Advanced document color");

Console.WriteLine("\nUsing advanced printer for scanning: ");
advancedPrinterScanner.ScanDocument("Advanced document scan");