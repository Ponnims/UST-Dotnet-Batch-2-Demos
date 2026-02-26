using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;


// Lambda Expression is introduced in C# 3.0 and is a concise way to represent anonymous methods using a more readable syntax. Lambda expressions are often used with LINQ (Language Integrated Query) to perform operations on collections of data. They can also be used to create delegates or expression trees.
// syntax of lambda expression:
// (parameters) => expression // expression lambda
// (parameters) => { statements } // statement lambda

namespace CsharpFeatures
{
    public delegate void MyThirdDelegate(int x, int y);
    public delegate int MyFourthDelegate(int x, int y);


    public class LamdaSample
    {
        // lambda expression assigned to a delegate
        public MyThirdDelegate delobj = (a,b) => Console.WriteLine(a+b);
        public MyFourthDelegate delobj2 = (a,b) => a + b;

        // statement lambda expression assigned to a delegate
        public MyThirdDelegate delobj3 = (a, b) =>
        {
            int sum = a + b;
            int diff = a - b;
            int prod= a * b;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + diff);
            Console.WriteLine("Product: " + prod);
        };
    }
    internal class LambdaDemo
    {
        static void Main(string[] args)
        {
            LamdaSample obj = new LamdaSample();
            obj.delobj(10, 12);
            obj.delobj2(20, 30);
        }
    }
}
