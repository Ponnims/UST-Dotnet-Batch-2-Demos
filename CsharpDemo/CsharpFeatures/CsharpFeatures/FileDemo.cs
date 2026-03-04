using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class FileDemo
    {
        static void Main(string[] args)
        {
            string path= @"d:\myfile.txt";

            if(File.Exists(path))
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            string destinpath= @"d:\Destin\newnewnew.txt";
            File.Copy(path, destinpath,true);
            Console.WriteLine("File Copied...Plz check");

            string delpath= @"d:\Destin\newnewnew.txt";
            File.Delete(delpath);
            Console.WriteLine("File Deleted...Plz check");
        }
    }
}
