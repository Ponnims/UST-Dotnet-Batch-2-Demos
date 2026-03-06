using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewFeatures
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class TargetTyped
    {

        static string GetCategory(int age) =>
            age switch
            {
                < 18 => "Child",
                >= 18 and < 65 => "Adult",
                _ => "Senior"
            };
        static void Main(string[] args)
        {
            Employee emp = new() { Id = 1, Name = "John" };
            List<int> scores = new() { 90, 80, 70 };
            int[] numbers = new[] { 1, 2, 3, 4, 5 };

            // collection Expressions C# 12 feature

            int[] scoress = [90, 80, 70];

            int[] moreScores = [.. scoress, 60, 50];

            foreach (var score in moreScores)
            {
                Console.WriteLine(score);
            }
            // Raw string literals C# 14 feature
            string myjsondata ="""

                
                {
                    "Id": 1,
                    "Name": "John"
                }
                """;
            Console.WriteLine(myjsondata);

            Console.WriteLine(GetCategory(35));
        }
    }
}
