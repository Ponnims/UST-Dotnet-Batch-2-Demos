using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AsynchronousDemo
{
    internal class RealtimeParallel
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Starting Downloads...");
            Task file1 = DownloadFile("File1");
            Task file2 = DownloadFile("File2");
            Task file3 = DownloadFile("File3");
            await Task.WhenAll(file1, file2, file3);
            stopwatch.Stop();

            Console.WriteLine($"Total Time Taken: {stopwatch.ElapsedMilliseconds} ms");

        }

        static async Task DownloadFile(string filename)
        {
            Console.WriteLine($"Downloading {filename}...");
            await Task.Delay(3000); // Simulate a long-running download operation
            Console.WriteLine($"{filename} Downloaded");
            // display thread id
           Console.WriteLine($"Thread ID for {filename}: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
