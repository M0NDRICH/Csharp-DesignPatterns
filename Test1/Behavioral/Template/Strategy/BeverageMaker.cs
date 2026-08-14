using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template.Strategy
{
    public class BeverageMaker
    {
        private Beverage _beverage;

        public BeverageMaker(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            // Common Operations
            BoilWater();
            PourIntoCup();

            // Unique Operations
            _beverage.Prepare();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourIntoCup()
        {
            Console.WriteLine("Pouring boiled water into cup");
        }
    }
}
