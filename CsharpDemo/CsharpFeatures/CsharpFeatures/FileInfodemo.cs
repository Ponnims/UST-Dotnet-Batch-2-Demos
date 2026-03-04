using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class FileInfoDemo
    {
        static void Main(string[] args)
        {
            string path = @"d:\fileinfodemo.txt";

            //FileInfo fileInfo = new FileInfo(path);
            //fileInfo.Create();

            FileInfo fileInfo1 = new FileInfo(path);
            StreamWriter sw= fileInfo1.AppendText();
            sw.WriteLine("This is a demo of FileInfo class in C#.");
            sw.WriteLine("We can create and manipulate files using FileInfo.");
            sw.Close();
            Console.WriteLine("File created successfully with some Conetnt Check....");


            // fileinfo1.Delete();
            // fileinfo1.CopyTo(@"d:\Destin\fileinfodemo.txt",true);
            // fileinfo1.MoveTo(@"d:\Destin\fileinfodemo.txt");


            Console.WriteLine(fileInfo1.FullName);
            Console.WriteLine(fileInfo1.CreationTime);
            Console.WriteLine(fileInfo1.LastAccessTime);
            Console.WriteLine(fileInfo1.LastWriteTime);
            Console.WriteLine(fileInfo1.Length);
            Console.WriteLine(fileInfo1.Name);
            Console.WriteLine(fileInfo1.DirectoryName);
            Console.WriteLine(fileInfo1.Extension);


        }
    }
}
