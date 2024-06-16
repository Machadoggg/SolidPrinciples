﻿namespace SolidPrinciples.OpenClose
{
    public class Square : IShape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }


        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
