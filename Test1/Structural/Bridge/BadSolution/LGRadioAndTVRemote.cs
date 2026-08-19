using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.BadSolution
{
    public class LGRadioAndTVRemote : RadioAndTVRemote
    {
        public override void ControlRadio()
        {
            Console.WriteLine("Now controlling LG radio");
        }

        public override void ControlTV()
        {
            Console.WriteLine("Now controlling LG TV");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turning LG radio off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Turning LG radio on");
        }

        public override void VolumeDown()
        {
            Console.WriteLine("Turning LG radio volume down");
        }

        public override void VolumeUp()
        {
            Console.WriteLine("Turning LG radio volume up");
        }
    }
}
