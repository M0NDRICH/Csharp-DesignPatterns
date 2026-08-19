using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.GoodSolution
{
    public class RemoteControl
    {
        // this interface is the bridge
        private IDevice _device;
        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        // you can see here that it's delegating the work to the device via the bridge
        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
