using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.GoodSolution
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }
}
