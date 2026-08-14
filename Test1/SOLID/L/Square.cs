using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.L
{
    public class Square : Shape
    {
        public double SideLength { get; set; }
        public override double Area => SideLength * SideLength;
    }
}
