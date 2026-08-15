using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.GoodSolution
{
    public class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging");
            return false;
        }
    }
}
