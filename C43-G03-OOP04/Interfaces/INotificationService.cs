using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Interfaces
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
