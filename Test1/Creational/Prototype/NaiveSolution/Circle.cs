using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype.NaiveSolution
{
    internal class Circle : IShape
    {
        public int Radius { get; set; } = 5;
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
