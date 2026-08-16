using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class RestaurantClient : Client
    {
        public RestaurantClient(string? name, string? email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending restaurant marketing tips email to "+ _email);
        }
    }
}
