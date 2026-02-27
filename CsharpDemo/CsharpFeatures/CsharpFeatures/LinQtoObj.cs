using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class LinQtoObj
    {
        static void Main(string[] args)
        {
            // DAta source
            List<Traineee> traineees = new List<Traineee>()
            {
                new Traineee(){ TraineeId=1, TraineeName="John", Technology="C#", Score=85},
                new Traineee(){ TraineeId=2, TraineeName="Alice", Technology="Java", Score=90},
                new Traineee(){ TraineeId=3, TraineeName="Bob", Technology="Python", Score=80},
                new Traineee(){ TraineeId=4, TraineeName="Eve", Technology="C#", Score=95},
            };
            // Query to fetch all trainees
            var QuerytofetchallTrainees = traineees.Select(t => t);

            // Executing the query and displaying results
            foreach (var trainee in QuerytofetchallTrainees)
            {
                Console.WriteLine($"ID: {trainee.TraineeId}, Name: {trainee.TraineeName}, Technology: {trainee.Technology}, Score: {trainee.Score}");
            }
        }
    }
}
