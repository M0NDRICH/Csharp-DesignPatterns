using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Validator
    {
        public void Validate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            // Trim whitespace
            request.ValidatedUserName = username!.Trim();
            request.ValidatedPassword = password!.Trim();
        }
    }
}
