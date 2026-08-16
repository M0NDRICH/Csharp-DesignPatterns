using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public class RetailClient : Client
    {
        public RetailClient(string? name, string? email) : base(name, email)
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitRetail(this);
        }
    }
}
