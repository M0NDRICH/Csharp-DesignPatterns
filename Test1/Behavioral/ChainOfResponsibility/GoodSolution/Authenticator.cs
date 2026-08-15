using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.GoodSolution
{
    public class Authenticator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authenticating");
            var username = request.GetUsername();
            var password = request.GetPassword();

            return !(username == "danny" && password == "123");
        }
    }
}
