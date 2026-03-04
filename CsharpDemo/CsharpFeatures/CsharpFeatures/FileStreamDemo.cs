using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class FileStreamDemo
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"d:\myfile.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("THis is a demo of FileStream and StreamWriter in C#.");
            sw.WriteLine("We can write data to the file using StreamWriter.");
            sw.Close();
            fs.Close();

            Console.WriteLine("File Created with some content, plz check ur file");

            try
            {

                using (FileStream fs1 = new FileStream(@"d:\myfileeee.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs1))
                    {
                        string content = sr.ReadToEnd();
                        Console.WriteLine("Content of the file:");
                        Console.WriteLine(content);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The File is Not Found " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
            
               
        }

    }
}
