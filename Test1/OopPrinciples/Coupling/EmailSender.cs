using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            // Email sending logic
            Console.WriteLine($"Sending email: {message}");
        }
    }
}
