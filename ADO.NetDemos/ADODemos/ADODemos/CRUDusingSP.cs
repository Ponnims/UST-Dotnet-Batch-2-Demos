using System;
using System.Collections.Generic;
using System.Text;

namespace ADODemos
{
    internal class CRUDusingSP
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();
            Console.WriteLine("CRUD Operations using Stored Procedures");
            Console.WriteLine("Enter the Learner Details:");
             Console.Write("Name: ");
             string name = Console.ReadLine();
             Console.Write("Stream: ");
             string stream = Console.ReadLine();
             Console.Write("Score: ");
             int score = int.Parse(Console.ReadLine());
            repo.AddLearnerusingquery(name, stream, score);

        }
    }
}
