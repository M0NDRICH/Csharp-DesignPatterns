using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    internal class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying blur overlay");
        }
    }
}
