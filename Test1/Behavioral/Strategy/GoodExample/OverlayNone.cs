using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    internal class OverlayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Not applying overlay");
        }
    }
}
