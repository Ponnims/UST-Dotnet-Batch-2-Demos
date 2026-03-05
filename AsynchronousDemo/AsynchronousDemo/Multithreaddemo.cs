using System;
using System.Collections.Generic;
using System.Text;


namespace AsynchronousDemo
{
    internal class Multithreaddemo
    {
        static void LongMethod()
        {
            Console.WriteLine("Long Method is Started");
            Thread.Sleep(6000);
            Console.WriteLine("Long Method is Done");
        }
        static void ShortMethod()
        {
            Console.WriteLine("Short Method is Started");
            Console.WriteLine("Short Method is Done");
        }
        static void Main(string[] args)
        {
            // LongMethod();
            Console.WriteLine("Main Thread Started");
            Thread thread = new Thread(LongMethod);
            thread.Start();
            ShortMethod();
            Console.WriteLine("Main Thread Stopped");
        }
    }
}
