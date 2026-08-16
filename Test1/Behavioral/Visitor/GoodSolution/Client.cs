using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public abstract class Client
    {
        protected string? _name;
        protected string? _email;
        public Client(string? name, string? email)
        {
            _name = name;
            _email = email;
        }

        public string? GetEmail()
        {
            return _email;
        }

        public abstract void Accept(Visitor visitor);
    }
}
