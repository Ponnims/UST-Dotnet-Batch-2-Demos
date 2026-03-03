using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADODemos
{
    internal class DisconnectedArchit
    {
        static void Main(string[] args)
        {
            try
            {
                string? ConString = "Server=(localdb)\\mssqllocaldb;Database=LearnersDB;Trusted_Connection=True;MultipleActiveResultSets=true";

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_learner", ConString);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "learner");

                foreach(DataRow row in dataSet.Tables["learner"].Rows)
                {
                    Console.WriteLine($"{row["Id"]}  -  {row["Name"]}  -  {row["Stream"]}  -   {row["Score"]}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
