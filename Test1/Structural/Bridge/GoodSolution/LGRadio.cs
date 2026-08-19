using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.GoodSolution
{
    public class LGRadio : IDevice
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting LG radio channel to " + channel);
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning LG radio off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning LG radio on");
        }
    }
}
