using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.O
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
