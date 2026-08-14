using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    internal class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying black and white overlay");
        }
    }
}
