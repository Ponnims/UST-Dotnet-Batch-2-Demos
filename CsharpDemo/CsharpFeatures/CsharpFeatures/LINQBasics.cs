using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class LINQBasics
    {
        static void Main(string[] args)
        {
            // 1.Create data source
            List<int> scores = new List<int>() { 89,79,56,45,23,46,90,100,12 };
            List<string> nameslist = new List<string>() 
            {"Raam","Sita","Krishna", "Ponni","Raja" };
            // We have 2 types of syntax to define a query in LINQ:
            // Query syntax: This is a declarative syntax that resembles SQL-like syntax. It uses keywords such as from, where, select, orderby, etc. to define the query. For example, you can define a query to fetch all scores using query syntax like this: var querytofetchallscores = from score in scores select score;.
            // Method syntax: This is a more functional programming style syntax that uses method chaining and lambda expressions to define the query. It uses extension methods such as Where(), Select(), OrderBy(), etc. to define the query. For example, you can define a query to fetch all scores using method syntax like this: var querytofetchallscores = scores.Select(score => score);.
            // 2. Define query using query syntax
            var querytofetchallscores = from score in scores
                                        select score;

            var querytofetchpassingscores = from score in scores
                                            where score >= 35
                                            select score;

            var querytofetchbetween80and100 = from score in scores
                                              where score >= 80 && score <= 100
                                              select score;

            var querytofetchnameswithlengthgreaterthan6 = from name in nameslist
                                                            where name.Length > 6
                                                            select name;



            // Method syntax
            var methodQueryToFetchAllScores = scores.Select(sc => sc);
            var methodQueryToFetchPassingScores = scores.Where(sc => sc >= 35);
            var methodQueryToFetchBetween80And100 = scores.Where(sc => sc >= 80 && sc <= 100);
            var methodQueryToFetchNamesWithLengthGreaterThan6 = nameslist.Where(name => name.Length > 6);

            // 2 types of execution in LINQ:
            // 1. Immediate execution: The query is executed immediately when it is defined. This means that the results are generated and stored in memory at the time of query definition. For example, if you define a query to fetch all scores, the results will be generated and stored in memory immediately, and any changes to the scores list after that will not affect the results of the query.
            // 2. Deferred execution: The query is not executed until you iterate over the results. This means that you can modify the data source after defining the query, and the changes will be reflected in the results when you execute the query. For example, if you add a new score to the scores list after defining the querytofetchallscores, the new score will be included in the results when you iterate over querytofetchallscores.

            // immediate Execution: The query is executed immediately when it is defined. This means that the results are generated and stored in memory at the time of query definition. For example, if you define a query to fetch all scores, the results will be generated and stored in memory immediately, and any changes to the scores list after that will not affect the results of the query.

            var immdquerytofetchbetween80and100 = (from score in scores
                                              where score >= 80 && score <= 100
                                              orderby score descending
                                               select score).ToList();

            Console.WriteLine($"THis is to check {immdquerytofetchbetween80and100.Count} items");
            // Deffered execution: The query is not executed until you iterate over the results. This means that you can modify the data source after defining the query, and the changes will be reflected in the results when you execute the query. For example, if you add a new score to the scores list after defining the querytofetchallscores, the new score will be included
            // in the results when you iterate over querytofetchallscores.

            Console.WriteLine("All Scores:");
            foreach (var item in querytofetchallscores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("PassedScores");
            foreach(var item in querytofetchpassingscores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Scores between 80 and 100:");
            foreach(var item in querytofetchbetween80and100)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Names with length greater than 6:");
            foreach(var item in querytofetchnameswithlengthgreaterthan6)
            {
                Console.WriteLine(item);
            }
        }
    }
}
