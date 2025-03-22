
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public interface INotificationService
    {
        void SendMessage(string message);
    }

    public class EmailService : INotificationService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    public class Notification
    {
        private EmailService _sendEmail;
        public Notification(INotificationService notificationService) 
        {
            _sendEmail = (EmailService)notificationService;
        }

        public void ApplyMessage()
        {
            _sendEmail.SendMessage("Hello, Dependency Inversion!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            EmailService semdEmail = new EmailService();

            Notification notification = new Notification(semdEmail);
            notification.ApplyMessage();

            Console.ReadLine();

        }
    }
}
