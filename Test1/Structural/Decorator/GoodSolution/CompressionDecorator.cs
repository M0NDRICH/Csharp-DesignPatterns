using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator.GoodSolution
{
    internal class CompressionDecorator : DataDecorator
    {
        public CompressionDecorator(IData data) : base(data)
        { }
        public override void Save(string data)
        {
            Console.WriteLine("Compressing data");
            var compressed = Compress(data);
            base._data.Save(compressed);
        }

        public string Compress(string data)
        {
            return data.Substring(0, 9);
        }
    }
}
