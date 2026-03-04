using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class LoggingDemo
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int res = a / b;
            }
                        catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            //Console.WriteLine();

            //1.Setup Dependency Injection Container
            var serviceProvider = new ServiceCollection().AddLogging(config =>
            {
                config.AddConsole();
                config.SetMinimumLevel(LogLevel.Error);// trace, information, warning, error, critical

            }).BuildServiceProvider();

            //2. Create a logger instance
            var logger= serviceProvider.GetService<ILoggerFactory>().CreateLogger<LoggingDemo>();

            string username= "admin";
            logger.LogInformation("User {Username} has logged in.", username);

            logger.LogTrace("THis is a trace log");
            logger.LogInformation("This is an information log");
            logger.LogWarning("This is a warning log");
            logger.LogError("This is an error log");
            logger.LogCritical("This is a critical log");
            logger.LogDebug("This is a debug log");


        }
    }
}
