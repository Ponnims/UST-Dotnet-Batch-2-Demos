using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class TeaxtReadWritdemo
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText(@"D:\tw.txt"))
            {
                writer.WriteLine("This is a demo of TextWriter in C#.");
                writer.WriteLine("We can write text to the file using TextWriter.");
            }
            Console.WriteLine("File created with some content...Check");

            using (TextReader reader = File.OpenText(@"D:\tw.txt"))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Content of the file:");
                Console.WriteLine(content);
            }
        }
    }
}
