using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.O
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
