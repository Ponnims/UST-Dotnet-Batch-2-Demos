using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;


// ADO.Net is a set of classes that expose data access services for .NET Framework programmers. It provides a rich set of components for creating distributed, data-sharing applications. ADO.Net is part of the base class library that comes with the .NET Framework
// and provides a bridge between the front end controls and the back end database.
// ADO.Net Supports 2 main Architectures:
// 1. Connected Architecture:
//    In this architecture, the application maintains a connection to the database
//    while performing operations. It uses classes like
//    SqlConnection, SqlCommand, and SqlDataReader to interact with the database in real-time.
// 2. Disconnected Architecture:
// In this architecture, the application retrieves data from the database and
// works with it in memory without maintaining a constant connection.
// It uses classes like DataSet, DataTable, and DataAdapter to manage data in a
// disconnected manner.
namespace ADODemos
{
    internal class ConnectionCheck
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Checking database connection...");
                string? ConString = "Server=(localdb)\\mssqllocaldb;Database=LearnersDB;Trusted_Connection=True;MultipleActiveResultSets=true";

                SqlConnection Con = new SqlConnection(ConString);
                Con.Open();
                Console.WriteLine("Sql Server Connection Successful");
                Con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sql Server Connection Failed");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Con.Close(); //cannot be used here because of scope issue, it is only accessible in try block
                Console.WriteLine("Connection Check Completed");
            }
        }
    }
}
