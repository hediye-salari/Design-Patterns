using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethodPattern.NotificationSystem
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();

        public void SendNotification(string message)
        {
            var notification = CreateNotification();
            Console.WriteLine("Preparing to send notification...");
            notification.Send(message);
        }
    }
}

