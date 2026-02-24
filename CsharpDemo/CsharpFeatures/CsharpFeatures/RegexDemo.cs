using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CsharpFeatures
{
    internal class RegexDemo
    {
        static void Main(string[] args)
        {
            string input = "6234567890";
            Regex regex = new Regex(@"[6789]\d{9}");

            if(regex.IsMatch(input))
            {
                Console.WriteLine("The input is a valid mobile number.");
            }
            else
            {
                Console.WriteLine("The input is not a valid Mobile number.");
            }
        }
    }
}
