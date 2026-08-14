using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.OopPrinciples.Polymorphism
{
    internal class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping.");
        }
    }
}
