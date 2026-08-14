using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template.Strategy
{
    public class Camomile : Beverage
    {
        public void Prepare()
        {
            Brew();
        }

        public void Brew()
        {
            Console.WriteLine("Brewing for 3 minutes.");
        }
    }
}
