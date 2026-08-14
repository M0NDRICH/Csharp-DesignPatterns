using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.OopPrinciples.Polymorphism
{
    internal class Plane : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public override void Start()
        {
            Console.WriteLine("Plane is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Plane is stopping.");
        }
    }
}
