using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethodPattern.NotificationSystem
{
    public class SmsNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
           return new SmsNotification();
        }
    }
}
