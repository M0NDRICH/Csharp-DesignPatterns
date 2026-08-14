using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.OopPrinciples.Coupling
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}
