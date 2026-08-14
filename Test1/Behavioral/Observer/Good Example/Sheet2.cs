using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer.Good_Example
{
    internal class Sheet2 : IObserver
    {
        private int _total;
        private DataSource _datasource;
        public Sheet2(DataSource datasource)
        {
            _datasource = datasource;
        }

        public int GetTotal()
        {
            return _total;
        }
        public void Update()
        {
            _total = CalculateTotal(_datasource.GetValues());
        }

        public int CalculateTotal(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            Console.WriteLine("Total : " + sum);
            return sum;
        }
    }
}
