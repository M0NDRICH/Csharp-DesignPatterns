using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template.Strategy
{
    public class Coffee : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing coffee for 5 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding cream to the coffee");
            }
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like cream with your coffee? (y/n)");
            string? input = (Console.ReadLine() ?? "").ToLower();
            Console.WriteLine("Userinput is {0}", input);

            if (input == "yes" || input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
