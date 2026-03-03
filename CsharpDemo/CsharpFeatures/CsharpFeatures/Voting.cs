using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class Voting
    {
        static void ValidateAge(int age)
        {
            if (age < 18)

                throw new InvalidAgeforVotingException("Age must be 18 or older to vote.");

        }
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Enter your age:");

                age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine("You are eligible to vote.");
            }
            catch (InvalidAgeforVotingException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("This is the End");
        }
    }
}
