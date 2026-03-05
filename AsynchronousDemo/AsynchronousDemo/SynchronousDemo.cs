using System;
using System.Collections.Generic;
using System.Text;

// By Default C# is Synchronous Programming Language.
// It executes the code line by line.
// If there is a long running method,
// it will block the execution of the next line of code
// until the long running method is completed.
// In the below example, LongMethod() is a long running method that takes 6 seconds
// to complete. ShortMethod() is a short running method that executes immediately
// after LongMethod() is called.
// However, ShortMethod() will not execute until LongMethod() is completed,
// which demonstrates the synchronous nature of C# programming.
namespace AsynchronousDemo
{
    internal class SynchronousDemo
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
            // As the long method takes more time to execute,
            //it will block the execution of the short method until it is completed.
            // in UI applications, this can lead to unresponsive user interfaces,
            // as the UI thread is blocked while waiting for the long method to complete.
            LongMethod();
            ShortMethod();
        }
    }
}
