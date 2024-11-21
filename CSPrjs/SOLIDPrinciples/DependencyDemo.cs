using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class DependencyDemo
    {
    }

    //without dependency principle

    //Lower level module

    
    interface IMessageService
    {
        void SendMessage(string message);
    }
    class EmailService : IMessageService 
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Sending email:" + msg);
        }
    }
    class SmsService : IMessageService 
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Sending sms:" + msg);
        }
    }

    //Higher-level module
    class Notification
    {
        IMessageService msgService;
        public Notification(IMessageService msgService)
        {
            this.msgService=msgService;
        }
        public void Notify(string msg)
        {
            msgService.SendMessage(msg);
        }
    }
}
