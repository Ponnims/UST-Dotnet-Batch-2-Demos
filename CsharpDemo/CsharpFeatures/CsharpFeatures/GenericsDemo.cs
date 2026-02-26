using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    class TestClass
    {
        private int data;
        public void SetData(int value)
        {
            data = value;
        }
        public int GetData()
        {
            return data;
        }
    }
    // generic class is a class that can work with any data type. It is defined with a type parameter, which is a placeholder for the data type that will be specified when the class is instantiated. This allows you to create a single class that can work with different data types without the need for code duplication.
    class MyGenericClass<T,U>
    {
        private T data;
        private U additionalData;
        public void SetData(T value, U additionalValue)
        {
            data = value;
            additionalData = additionalValue;
        }
        public T GetData()
        {
            return data;
        }
    }
    internal class GenericsDemo
    {
        static void Main(string[] args)
        {
            TestClass obj1 = new TestClass();
            obj1.SetData(42); // works fine because SetData expects an int
            //obj1.SetData("Hi");// error because SetData expects an int, not a string so it is specific to a particular data type
            Console.WriteLine("Data from TestClass: " + obj1.GetData());


            MyGenericClass<int,string> obj2 = new MyGenericClass<int,string>();
            obj2.SetData(42, "The Answer");
            Console.WriteLine("Data from MyGenericClass<int>: " + obj2.GetData());

            MyGenericClass<string,float> obj  = new MyGenericClass<string,float>();
            obj.SetData("Hello, Generics!", 3.14f);
            Console.WriteLine("Data from MyGenericClass<string>: " + obj.GetData());

            MyGenericClass<double,string> obj3 = new MyGenericClass<double,string>();
            obj3.SetData(3.14, "Pi");
            Console.WriteLine("Data from MyGenericClass<double>: " + obj3.GetData());

            MyGenericClass<int,int> obj4 = new MyGenericClass<int,int>();
            obj4.SetData(10, 20);
            Console.WriteLine("Data from MyGenericClass<int>: " + obj4.GetData());

            //Dictionary<string, int> dict = new Dictionary<string, int>();
        }
    }
}
