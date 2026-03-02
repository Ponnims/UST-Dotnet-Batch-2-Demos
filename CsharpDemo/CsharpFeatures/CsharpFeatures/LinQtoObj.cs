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
                new Traineee(){TraineeId=5,TraineeName="Rinu", Technology="Java", Score=80},
                new Traineee(){TraineeId=6, TraineeName="Prem", Technology="Python", Score=70}
            };
            // Query to fetch all trainees
            var QuerytofetchallTrainees = traineees.Select(t => t);

            // Executing the query and displaying results
            foreach (var trainee in QuerytofetchallTrainees)
            {
                Console.WriteLine($"ID: {trainee.TraineeId}, Name: {trainee.TraineeName}, Technology: {trainee.Technology}, Score: {trainee.Score}");
            }

            // Anonymous type
            var mydata = new { Name = "MSP", Location = "Chennai", Technology = "AgenticAI" };



            var QuerytoFetchSpecificCols = (from t in traineees
                                            select new { tname = t.TraineeName, tscore = t.Score }).ToList();


            var Querytofetchspecificcolsmethodsynatx = traineees.Select(t => t.TraineeName).ToList();

            foreach (var trainee in QuerytoFetchSpecificCols)
            {
                Console.WriteLine($"Name: {trainee.tname}, Score: {trainee.tscore}");
            }

            var QueryTechwisemaxscore = from t in traineees
                                        group t by t.Technology into grptech
                                        select new { technology = grptech.Key, maxscore = grptech.Max(x => x.Score) };


            QueryTechwisemaxscore.ToList().ForEach(x => {
                Console.WriteLine(x.technology);
                Console.WriteLine(x.maxscore);
            });

            var QuerywithGroupbyTech = traineees.GroupBy(t => t.Technology);

            foreach(var res in QuerywithGroupbyTech)
            {
                Console.WriteLine($"The Technology {res.Key} has the max score : {res.Max(x=>x.Score)}");
            }

            foreach(var ress in QuerywithGroupbyTech)
            {
                Console.WriteLine($"The Technology {ress.Key} has the count : {ress.Count()}");
            }
        }
    }

}