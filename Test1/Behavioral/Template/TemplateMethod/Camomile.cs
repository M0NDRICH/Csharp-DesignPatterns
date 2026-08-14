using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template.TemplateMethod
{
    public class Camomile : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brew camomile for 3 mins");
        }
    }
}
