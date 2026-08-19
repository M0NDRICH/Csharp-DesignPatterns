using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class BlackAndWhite : IColor
    {
        public void Apply(Video video)
        {
            Console.WriteLine("Applying Black and White to video...");
        }
    }
}
