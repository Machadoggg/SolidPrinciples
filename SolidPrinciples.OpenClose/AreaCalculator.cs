namespace SolidPrinciples.OpenClose
{
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape) 
        {
            return shape.CalculateArea();
        }
    }
}
