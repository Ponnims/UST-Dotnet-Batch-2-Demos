using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewFeatures
{
    class Trainee(int id, string name,string technology)
    {
        public int Id => id;
        public string Name => name;
        public string Technology => technology;
    }
    public class PrimaryConst
    {
        static void Main(string[] args)
        {
            // Trainee t = new Trainee(); // This will give an error because the primary constructor requires parameters.

            Trainee trainee = new Trainee(1, "John", "C#");

            //trainee.Name = "Jane"; // This will give an error because the properties are read-only.
            Console.WriteLine($"Id: {trainee.Id}, Name: {trainee.Name}, Technology: {trainee.Technology}");
        }
    }
}
