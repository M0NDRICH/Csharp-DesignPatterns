using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.BadSolution
{
    public abstract class RadioAndTVRemote : RemoteControl
    {
        public abstract void ControlTV();
        public abstract void ControlRadio();
    }
}
