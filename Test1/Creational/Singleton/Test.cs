using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    internal class Test
    {
        public static void Run()
        {
            var settings = AppSettings.GetInstance();
            Console.WriteLine(settings.Get("app_name"));
        }
    }
}
