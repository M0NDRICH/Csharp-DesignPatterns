using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    internal class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using MOV");
        }
    }
}
