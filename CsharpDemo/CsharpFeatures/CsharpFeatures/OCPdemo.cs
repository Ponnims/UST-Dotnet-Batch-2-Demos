using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    interface INotification
    {
        void Notify(string message);
    }

    class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email notification: {message}");
        }
    }

    class SMSNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS notification: {message}");
        }
    }

    class WhatsAppNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"WhatsApp notification: {message}");
        }
    }

    

    class InstagramNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Instagram notification: {message}");
        }
    }

    class TwitterNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Twitter notification: {message}");
        }
    }

    internal class OCPdemo
    {
        static void Main(string[] args)
        {

        }
    }
}
