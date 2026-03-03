using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADODemos
{
    internal class Repository
    {

        string? ConString = "Server=(localdb)\\mssqllocaldb;Database=LearnersDB;Trusted_Connection=True;MultipleActiveResultSets=true";

        public void AddLearnerusingquery(string name, string stream,int score)
        {
            using (SqlConnection Con = new SqlConnection(ConString))
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_learner (Name, Stream, Score) VALUES (@Name, @Stream, @Score)", Con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Stream", stream);
                cmd.Parameters.AddWithValue("@Score", score);
                int rows=cmd.ExecuteNonQuery();
                Console.WriteLine($"{rows} row(s) inserted.");
            }
        }

        public void AddLearnerusingSP(string name, string stream, int score)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("usp_add_learner",con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@stream", stream);
                cmd.Parameters.AddWithValue("@score", score);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rows} row(s) inserted.");


            }
        }


    }
}
