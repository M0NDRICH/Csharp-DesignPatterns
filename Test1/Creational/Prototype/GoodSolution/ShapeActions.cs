using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype.GoodSolution
{
    internal class ShapeActions
    {
        public IShape Duplicate(IShape shape)
        {
            Console.WriteLine("Duplicating shape.");
            return shape.Duplicate();
        }
    }
}
