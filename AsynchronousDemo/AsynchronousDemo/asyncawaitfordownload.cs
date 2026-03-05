using System;
using System.Collections.Generic;
using System.Text;

namespace AsynchronousDemo
{
    internal class asyncawaitfordownload
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Program Started");
            await DownloadData();
            Console.WriteLine("Program Finished");
        }

        static async Task DownloadData()
        {
            Console.WriteLine("Downloading Data.....");
            await Task.Delay(5000); // Simulate a long-running download operation
            Console.WriteLine("Download Completed");
        }
    }
}
