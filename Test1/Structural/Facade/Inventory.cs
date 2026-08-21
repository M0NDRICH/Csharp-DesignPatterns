using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class Inventory
    {
        public bool CheckInventory(string itemId)
        {
            return true; // just return true to keep example simple
        }

        public void ReduceInventory(string itemId, int amount)
        {
            Console.WriteLine("Reducing inventory of "+ itemId +" by "+ amount);
        }
    }
}
