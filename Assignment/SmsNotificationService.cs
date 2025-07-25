using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class SmsNotificationService:INotificationService
    {
        public void SendNotification(string recipent, string message)
        {
            Console.WriteLine($"SMS is received by {recipent} and message is:{message}");
        }
    }
}
