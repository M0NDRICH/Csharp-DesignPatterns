using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public interface Visitor
    {
        void VisitRetail(RetailClient retailClient);
        void VisitLaw(LawClient lawClient);
        void VisitRestaurant(RestaurantClient restaurantClient);
    }
}
