using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype.GoodSolution
{
    internal interface IShape
    {
        void Draw();
        IShape Duplicate();
    }
}
