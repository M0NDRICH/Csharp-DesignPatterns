using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public class RestaurantClient : Client
    {
        public RestaurantClient(string? name, string? email) : base(name, email)
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitRestaurant(this);
        }
    }
}
