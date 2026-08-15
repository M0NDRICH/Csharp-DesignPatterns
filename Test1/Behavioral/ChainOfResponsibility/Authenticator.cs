using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            return username == "danny" && password == "123";
        }
    }
}
