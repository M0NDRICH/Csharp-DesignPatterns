using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template.BadExample
{
    public class Tea
    {
        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourWaterIntoCup()
        {
            Console.WriteLine("Pouring water into cup");
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
