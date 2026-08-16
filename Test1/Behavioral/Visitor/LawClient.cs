using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class LawClient : Client
    {
        public LawClient(string? name, string? email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending law marketing tips email to "+ _email);
        }
    }
}
