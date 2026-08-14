using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.I
{
    internal class Circle : IShape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
