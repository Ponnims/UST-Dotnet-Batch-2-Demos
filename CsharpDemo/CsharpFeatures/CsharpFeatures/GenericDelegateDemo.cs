using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    // generic Delagates are a powerful feature in C# that allow you to define delegates that can work with any data type. They are defined with a type parameter, which is a placeholder for the data type that will be specified when the delegate is instantiated. This allows you to create a single delegate that can work with different data types without the need for code duplication.
    // 1. Func<>
    //  Func<> has both return type and parameters. The last type parameter is the return type, and the preceding type parameters are the input parameters. For example, Func<int, int, int> represents a delegate that takes two integers as input and returns an integer as output.

    //Func<T1,T2,T3,T4, TResult> represents a delegate that takes four parameters of types T1, T2, T3, and T4, and returns a value of type TResult. For example, Func<int, int, int, int, int> represents a delegate that takes four integers as input and returns an integer as output.
    // 2. Action<>
    // Action<> doesnt have return type, it only has parameters. For example, Action<string> represents a delegate that takes a string as input and returns void
    internal class GenericDelegateDemo
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Func<string> disp= () => "Hello, World!";
            Func<int, int> incr = (a) => a + 2;

            Action<int> print = (i) => Console.WriteLine("This is an Action delegate with no parameters.");

            Action<string> printMessage = (message) => Console.WriteLine("Message: " + message);



        }
    }
}
