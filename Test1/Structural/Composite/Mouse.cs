using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class Mouse : IITem
    {
        public float Price { private get; set; } = 18.00f;

        public float GetPrice() => Price;
    }
}
