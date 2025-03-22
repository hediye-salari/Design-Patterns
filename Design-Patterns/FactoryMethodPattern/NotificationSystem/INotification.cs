using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethodPattern.NotificationSystem
{
     public interface INotification
    {
        void Send(string message);
    }
}
