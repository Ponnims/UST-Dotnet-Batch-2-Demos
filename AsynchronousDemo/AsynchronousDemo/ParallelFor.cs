using System;
using System.Collections.Generic;
using System.Text;

namespace AsynchronousDemo
{
    internal class ParallelFor
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 20, i =>
            {
                double result = 0;

                for (int j = 0; j < 100000000; j++)
                {
                    result += Math.Sqrt( j);
                }
                Console.WriteLine($"Task {i} Result: {result}");
            });
            Console.WriteLine("All done");

            
        }
    }
}
