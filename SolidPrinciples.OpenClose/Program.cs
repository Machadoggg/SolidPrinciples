

using SolidPrinciples.OpenClose;

IShape circle = new Circle(5);
IShape rectangle = new Rectangle(3, 4);
IShape square = new Square(6);


AreaCalculator calculator = new AreaCalculator();


Console.WriteLine($"Circle area: {calculator.CalculateArea(circle)}");
Console.WriteLine($"Rectangle area: {calculator.CalculateArea(rectangle)}");
Console.WriteLine($"Square area: {calculator.CalculateArea(square)}");