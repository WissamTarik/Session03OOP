using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipent, string message)
        {
            Console.WriteLine($"Email is received by {recipent} and message is:{message}") ;
        }
    }
}
