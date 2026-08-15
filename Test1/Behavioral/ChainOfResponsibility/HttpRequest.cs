using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string? _username;
        private string? _password;
        public string ValidatedUserName { get; set; }
        public string ValidatedPassword { get; set; }

        public HttpRequest(string? username, string password)
        {
            _username = username;
            _password = password;
        }

        public string? GetUsername()
        {
            return _username;
        }

        public string? GetPassword()
        {
            return _password;
        }
    }
}
