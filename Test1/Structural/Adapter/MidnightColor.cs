using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class MidnightColor : IColor
    {
        public void Apply(Video video)
        {
            Console.WriteLine("Applying Midnight-purple Color to video...");
        }
    }
}
