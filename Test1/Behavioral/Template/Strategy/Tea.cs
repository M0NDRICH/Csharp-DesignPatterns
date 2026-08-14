using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template.Strategy
{
    public class Tea : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding lemon to the tea");
            }
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea (y/n)?");
            string? input = (Console.ReadLine() ?? "").ToLower();
            Console.WriteLine("User input: {0}", input);

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
