using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    internal class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using MP4");
        }
    }
}
