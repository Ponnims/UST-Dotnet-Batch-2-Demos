using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AsynchronousDemo
{
    internal class Realtimedemo
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Starting Downloads...");
            await DownloadFile("File1");
            await DownloadFile("File2");
            await DownloadFile("File3");
            stopwatch.Stop();

            Console.WriteLine($"Total Time Taken: {stopwatch.ElapsedMilliseconds} ms");

        }

        static async Task DownloadFile(string filename)
        {
                Console.WriteLine($"Downloading {filename}...");
                await Task.Delay(3000); // Simulate a long-running download operation
                Console.WriteLine($"{filename} Downloaded");
        }
    }
}
