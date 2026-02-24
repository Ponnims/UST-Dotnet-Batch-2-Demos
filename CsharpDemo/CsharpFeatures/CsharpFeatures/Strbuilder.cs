using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class Strbuilder
    {
        static void Main(string[] args)
        {
            string first = "MSP";
            string second = "Training";

            // second =string.Concat(first, second); // Concatenation using string.Concat method

            second += first;

            Console.WriteLine($"first is {first}");
            Console.WriteLine($"second is {second}");

            // strings are immutable in C#, which means that once a string is created, it cannot be changed. When you perform any operation that modifies a string, such as concatenation or substring extraction, a new string is created in memory to hold the modified value. This immutability of strings can lead to performance issues when performing multiple string manipulations, as it creates multiple string objects in memory. To address this issue, C# provides the StringBuilder class, which allows for efficient manipulation of strings without creating multiple objects. The StringBuilder class provides methods for appending, inserting, removing, and replacing characters in a string without creating new string objects, making it more efficient for scenarios that involve extensive string manipulation.

            // string builder is mutable, which means
            // that it can be modified after it is created.
            // It provides methods for appending, inserting, removing,
            // and replacing characters in a string without
            // creating new string objects, making it more efficient
            // for scenarios that involve extensive string manipulation.
             StringBuilder sb = new StringBuilder("MSP Training");
             sb.Append(" C#"); // appending a string to the StringBuilder
             sb.Insert(0, "Welcome to "); // inserting a string at the beginning of the StringBuilder
             sb.Replace("Training", "Course"); // replacing a substring in the StringBuilder
             sb.Remove(0, 11); // removing a substring from the StringBuilder
             Console.WriteLine(sb.ToString()); // converting the StringBuilder to a string and printing it

        }
    }
}
