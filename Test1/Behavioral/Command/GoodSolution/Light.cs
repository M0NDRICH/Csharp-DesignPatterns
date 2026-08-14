using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.GoodSolution
{
    // Receiver
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }

        public void Dim()
        {
            Console.WriteLine("Light is dim");
        }
    }
}
