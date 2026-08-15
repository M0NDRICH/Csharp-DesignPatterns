using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.GoodSolution
{
    public class Validator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Validating");
            var username = request.GetUsername();
            var password = request.GetPassword();

            // Trim
            request.ValidatedUserName = username.Trim();
            request.ValidatedPassword = password.Trim();

            return request.ValidatedUserName == "" || request.ValidatedPassword == "";
        }
    }
}
