using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer.Good_Example
{
    internal class BarChart : IObserver
    {
        private DataSource _dataSource;
        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Rendering bar chart with the new values");
        }
    }
}
