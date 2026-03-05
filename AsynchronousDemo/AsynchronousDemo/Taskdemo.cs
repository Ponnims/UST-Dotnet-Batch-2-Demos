using System;
using System.Collections.Generic;
using System.Text;

namespace AsynchronousDemo
{
    internal class Taskdemo
    {
        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Task Running : {i}");
                Task.Delay(1000).Wait(); // Simulate some work
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            Task task = Task.Run(() => PrintNumbers());
            Console.WriteLine("Main Thread Stopped");
            Console.ReadLine();
        }
    }
}
