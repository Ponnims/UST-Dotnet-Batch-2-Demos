using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    // in c
    // int a = 10;
    // int *ptr = &a;  printf("Value of a: %d", *(ptr));
    // string myname= "John";
    // string *ptr1 = &myname; printf("Value of myname: %s", *(ptr1));

    // Delegate feature was introduced in C# 1.0 and has been enhanced
    // in later versions. Delegates are used to define callback methods
    // and implement event handling. They allow you to encapsulate a
    // method reference and invoke it later.
    // delegate is function pointer, delegate is going to rfere the 
    // function.
    // delegates signature should match with the signature of the method it is going to refer to.

    public delegate void MyFirstDelegate(int firstnumber, int secondnumber); // declaring a delegate


    class MyClass
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }
        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine("Division: " + (a / b));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }

    internal class DelegateDemo
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            MyFirstDelegate delobj = new MyFirstDelegate(obj.Add);
            delobj += obj.Subtract; // Multicasting the delegate
            delobj += obj.Multiply; // Multicasting the delegate
            delobj += obj.Divide; // Multicasting the delegate
            delobj(10, 20); // invoking the delegate
        }
    }
}
