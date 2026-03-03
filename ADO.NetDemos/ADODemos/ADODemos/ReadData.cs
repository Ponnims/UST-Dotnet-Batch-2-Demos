using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADODemos
{
    // Read Operation using Connected Architecture
    internal class ReadData
    {
        static void Main(string[] args)
        {
            try
            {
                string? ConString = "Server=(localdb)\\mssqllocaldb;Database=LearnersDB;Trusted_Connection=True;MultipleActiveResultSets=true";

                using (SqlConnection Con = new SqlConnection(ConString))
                {
                    Con.Open();
                    string selectquery = "SELECT * FROM tbl_learner";
                    SqlCommand cmd = new SqlCommand(selectquery, Con);

                    //cmd.executeNonQuery(); //used for insert, update, delete operations, it returns number of rows affected
                    //cmd.executeReader(); //used for select operations, it returns a SqlDataReader object that can be used to read the data
                    //cmd.executeScalar(); //used for select operations that return a single value, it returns the value of the first column of the first row in the result set


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"Learner ID: {reader["Id"]}, Name: {reader["Name"]}, Stream: {reader["Stream"]}, Score: {reader["Score"]}");
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
        }
    }
}
