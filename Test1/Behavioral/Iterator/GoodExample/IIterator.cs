using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Iterator.GoodExample
{
    public interface IIterator<T>
    {
        void Next();
        T Current();
        bool hasNext();
    }
}
