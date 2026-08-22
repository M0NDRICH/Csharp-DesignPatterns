using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype.NaiveSolution
{
    internal class Rectangle : IShape
    {
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 5;
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
