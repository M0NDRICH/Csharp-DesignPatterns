using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.S
{
    public class UserService
    {
        public void Register(User user)
        {
            // Register user logic


            // Send emaiil
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our platform");
        }
    }
}
