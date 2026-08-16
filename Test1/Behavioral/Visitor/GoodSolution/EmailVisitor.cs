using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public class EmailVisitor : Visitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            Console.WriteLine("Sending law marketing tips to "+ lawClient.GetEmail());
        }

        public void VisitRestaurant(RestaurantClient restaurantClient)
        {
            Console.WriteLine("Sending restaurant marketing tips to "+restaurantClient.GetEmail());
        }

        public void VisitRetail(RetailClient retailClient)
        {
            Console.WriteLine("Sending retail marketing tips to " + retailClient.GetEmail());
        }
    }
}
