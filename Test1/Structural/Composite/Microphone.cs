using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class Microphone : IITem
    {
        public float Price { private get; set; } = 29.99f;

        public float GetPrice() => Price;
    }
}
