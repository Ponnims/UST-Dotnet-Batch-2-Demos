using System;
using System.Collections.Generic;
using System.Text;

namespace AsynchronousDemo
{
    internal class Callapi
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Application Started");
           // await GetDatafromService1();
            //await GetDatafromService2();

            Task task1= GetDatafromService1();
            Task task2= GetDatafromService2();

            await Task.WhenAll(task1, task2);
            Console.WriteLine("Application Ended");
        }

        static async Task GetDatafromService1()
        {
            Console.WriteLine("Calling Service1...");
            await Task.Delay(3000); // Simulate a long-running API call
            Console.WriteLine("Recievd Data from Service 1.");
        }
        

        static async Task GetDatafromService2()
        {
            Console.WriteLine("Calling Service2...");
            await Task.Delay(2000); // Simulate a long-running API call
            Console.WriteLine("Recievd Data from Service 2.");
        }
    }
}
