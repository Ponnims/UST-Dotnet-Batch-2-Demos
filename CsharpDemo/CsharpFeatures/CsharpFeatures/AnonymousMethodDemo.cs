using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    public delegate void MySecondDelegate(int firstnumber, int secondnumber); // declaring a delegate
    internal class AnonymousMethodDemo
    {
        static void Main(string[] args)
        {
            MySecondDelegate obj = delegate (int x, int y)
            {
                Console.WriteLine("Addition: " + (x + y));
            };
            obj(10, 20);
        }
    }
}
