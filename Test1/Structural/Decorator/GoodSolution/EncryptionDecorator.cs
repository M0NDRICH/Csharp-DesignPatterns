using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator.GoodSolution
{
    internal class EncryptionDecorator : DataDecorator
    {
        public EncryptionDecorator(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            var encrypted = Encrypt(data);
            base._data.Save(encrypted);
        }

        public string Encrypt(string data)
        {
            return "$dkshf%***234ndb$$";
        }
    }
}
