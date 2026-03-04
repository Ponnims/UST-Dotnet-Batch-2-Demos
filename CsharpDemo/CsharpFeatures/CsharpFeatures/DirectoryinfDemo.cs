using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class DirectoryinfDemo
    {
        static void Main(string[] args)
        {
            string path= @"d:\msp";

            DirectoryInfo dirinfo= new DirectoryInfo(path);
            Console.WriteLine(dirinfo.FullName);
            Console.WriteLine(dirinfo.CreationTime);
            Console.WriteLine(dirinfo.LastAccessTime);
            Console.WriteLine(dirinfo.LastWriteTime);
            Console.WriteLine(dirinfo.GetFiles().Length);
            Console.WriteLine(dirinfo.Name);
            Console.WriteLine(dirinfo.Parent);
            Console.WriteLine(dirinfo.Root);
        }
    }
}
