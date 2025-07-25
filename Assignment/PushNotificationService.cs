using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PushNotificationService:INotificationService
    {
        public void SendNotification(string recipent, string message)
        {
            Console.WriteLine($"Push is received by {recipent} and message is:{message}");
        }
    }
}
