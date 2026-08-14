using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    internal class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using WEBM");
        }
    }
}
