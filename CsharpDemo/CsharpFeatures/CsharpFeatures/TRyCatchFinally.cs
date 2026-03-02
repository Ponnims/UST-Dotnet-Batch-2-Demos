using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class TRyCatchFinally
    {
        static void Main(string[] args)
        {

            int Firstnumber;
            int Secondnumber;
            int Result;
            try
            {
                Console.WriteLine("Enter the first number:");
                Firstnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                Secondnumber = Convert.ToInt32(Console.ReadLine());
                Result = Firstnumber / Secondnumber;
                Console.WriteLine($"The result is {Result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The Second no cannot be zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some unexpected error has occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This block will always execute, regardless of whether an exception was thrown or not.");
            }


            Console.WriteLine("This is the end of Program");


        }
    }
}
