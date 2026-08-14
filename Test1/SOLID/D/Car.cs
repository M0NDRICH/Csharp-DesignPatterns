using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.D
{
    internal class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started.");
        }
    }
}
