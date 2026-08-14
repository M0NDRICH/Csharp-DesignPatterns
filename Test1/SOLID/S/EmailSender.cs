using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.S
{
    public class EmailSender
    {
        public void SendEmail(string? email, string message)
        {
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}
