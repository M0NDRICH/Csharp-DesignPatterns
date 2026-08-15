using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Logger
    {
        public void Log(HttpRequest request)
        {
            Console.WriteLine("Log");
        }
    }
}
