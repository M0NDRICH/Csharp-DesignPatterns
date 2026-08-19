using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.BadSolution
{
    public abstract class AdvancedRemote : RemoteControl
    {
        public abstract void SetChannel(int channel);
    }
}
