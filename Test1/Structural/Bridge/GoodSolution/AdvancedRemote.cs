using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.GoodSolution
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting channel to " + channel);
        }
    }
}
