using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator.GoodSolution
{
    internal class CloudData : IData
    {
        private string _url;
        public CloudData(string url)
        {
            _url = url;
        }
        public void Save(string data)
        {
            Console.WriteLine($"Saving data '{data}' to cloud at '{_url}'");
        }
    }
}
