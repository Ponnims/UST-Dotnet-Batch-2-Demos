using System;
using System.Collections.Generic;
using System.Text;

namespace AsynchronousDemo
{
    internal class ThreadDemo
    {
        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(4000); // Simulate some work
            }
        }
        static void Main(string[] args)
        {
            // Thread is the smallest unit of execution in a program.
            Console.WriteLine("Main Thread is Started");
            Thread thread = new Thread(PrintNumbers);
            thread.Start();
            //PrintNumbers();
            Console.WriteLine("PrintNUmbers is done");
            Console.WriteLine("Main Thraed is Done");
            
        }
    }
}
