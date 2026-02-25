using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    class Notification
    {
        public string Message { get; set; }
        public string Notifythrough { get; set; }
        public void Notify(string message, string notifyThrough)
        {
            Message = message;
            if (notifyThrough == "Email")
            {
                Notifythrough = "Email";
                Console.WriteLine("Notification sent through Email: " + Message);
            }
            else if (notifyThrough == "SMS")
            {
                Notifythrough = "SMS";
                Console.WriteLine("Notification sent through SMS: " + Message);
            }
            else if (notifyThrough == "Whatsapp")
            {
                Notifythrough = "Whatsapp";
                Console.WriteLine("Notification sent through Push: " + Message);
            }
            else if(notifyThrough== "Insta")
            {                 Notifythrough = "Insta";
                Console.WriteLine("Notification sent through Insta: " + Message);
            }
        }
    }
    internal class NoOCP
    {
        static void Main(string[] args)
        {

        }
    }
}
