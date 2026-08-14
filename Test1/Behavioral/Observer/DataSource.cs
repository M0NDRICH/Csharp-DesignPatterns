using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class DataSource
    {
        private List<int> _values = new List<int>();

        // Observer
        private List<Object> _dependents = new List<Object>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;

            foreach (var dependent in _dependents)
            {
                if (dependent is Sheet2)
                {
                    (dependent as Sheet2)?.CalculateTotal(_values);
                }
                else if (dependent is BarChart)
                {
                    (dependent as BarChart)?.Render(_values);
                }
            }
        }

        public void AddDependent(Object dependent)
        {
            _dependents.Add(dependent);
        }

        public void RemoveDependent(Object dependent)
        {
            _dependents.Remove(dependent);
        }
    }
}
