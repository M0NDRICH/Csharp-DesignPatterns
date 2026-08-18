using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class Box : IITem
    {
        private List<IITem> _items = new();
        public float Price { get; set; } 

        public Box Add(IITem item)
        {
            _items.Add(item);

            return this;
        }

        public float GetPrice()
        {

            foreach (IITem item in _items)
            {
                Price += item.GetPrice();
            }

            return Price;
        }
    }
}
