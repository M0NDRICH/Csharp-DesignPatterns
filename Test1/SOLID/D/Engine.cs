using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }
}
