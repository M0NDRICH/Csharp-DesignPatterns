using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype.NaiveSolution
{
    internal class ShapeActions
    {
        public void Duplicate(IShape shape)
        {
            if (shape is Circle)
            {
                var copiedShape = (Circle)shape; // the copied shape
                var newShape = new Circle(); // the clone
                newShape.Radius = copiedShape.Radius;
                newShape.Draw();
            }
            else if (shape is Rectangle)
            {
                var copiedShape = (Rectangle)shape;
                var newShape = new Rectangle();
                newShape.Width = copiedShape.Width;
                newShape.Height = copiedShape.Height;
                newShape.Draw();
            }
            else
            {
                throw new ArgumentException("Invalid shape provided");
            }
        }
    }
}
