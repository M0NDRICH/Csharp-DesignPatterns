using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template.TemplateMethod
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            PourIntoCup();
            Brew();
            AddCondiments();
        }

        protected virtual void AddCondiments()
        {
            
        }

        protected abstract void Brew();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        private void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
