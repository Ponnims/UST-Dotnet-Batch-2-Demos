using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewFeatures
{
    internal class UseExtension
    {
        static void Main(string[] args)
        {
            int myscore = 345;
            string myemail = "msp@gmail.com";

            Console.WriteLine(myscore.IsEven());
            Console.WriteLine(myemail.IsValidEmail());
        }
    }
}
