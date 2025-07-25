using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces
{
    internal interface INotificationService
    {
        void SendNotification(string recipent, string message);
    }
}
