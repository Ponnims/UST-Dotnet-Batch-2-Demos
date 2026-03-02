using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class RuntimeErrordemo
    {
        static void Main(string[] args)
        {
            int firstnumber;
            int secondnumber;
            int result;
            Console.WriteLine("Enter the first number:");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            result=firstnumber / secondnumber;
            Console.WriteLine($" The result is {result}");

            Console.WriteLine("Division is Done");


            // Division by zero error
            // Array index out of bounds error
             int[] numbers = { 1, 2, 3 };
             Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException

            Console.WriteLine("Array Access is Done");
             // Null reference error
             string str = null;
             Console.WriteLine(str.Length); // This will throw a NullReferenceException

            Console.WriteLine("Null Reference is Done");

            Console.WriteLine("This is the End of the Program");
        }
    }
}
