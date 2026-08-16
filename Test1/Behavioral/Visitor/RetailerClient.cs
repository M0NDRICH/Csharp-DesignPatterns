using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    internal class RetailerClient : Client
    {
        public RetailerClient(string? name, string? email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending retailer marketing tips email to"+ _email); 
        }
    }
}
