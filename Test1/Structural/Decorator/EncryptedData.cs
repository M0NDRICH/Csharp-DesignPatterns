using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    internal class EncryptedData : CloudData
    {
        public EncryptedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var encrypted = Encrypt(data);
            base.Save(encrypted);
        }

        public string Encrypt(string data)
        {
            return $"dkshf%***234ndb$$";
        }
    }
}
