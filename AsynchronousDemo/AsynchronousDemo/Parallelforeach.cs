using System;
using System.Collections.Generic;
using System.Text;

namespace AsynchronousDemo
{
    internal class Parallelforeach
    {
        static void Main(string[] args)
        {
            List<string> Files = new List<string> { "File1", "File2", "Charlie", "David", "Eve" };
            Parallel.ForEach(Files, file =>
            {
                Console.WriteLine($"Processing {file} on the Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(2000); // Simulate some work
            });
            Console.WriteLine("All files processed");
        }
    }
}
