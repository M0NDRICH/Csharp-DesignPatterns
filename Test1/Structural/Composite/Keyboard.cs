using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class Keyboard : IITem
    {
        public float Price { private get; set; } = 40.00f;

        public float GetPrice() => Price;
    }
}
