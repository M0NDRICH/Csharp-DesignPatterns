using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator.GoodSolution
{
    internal abstract class DataDecorator : IData
    {
        // wrappee
        protected IData _data;

        public DataDecorator(IData data)
        {
            _data = data;
        }
        public abstract void Save(string data);
    }
}
