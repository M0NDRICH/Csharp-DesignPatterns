using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sms message: {message}");
        }
    }
}
