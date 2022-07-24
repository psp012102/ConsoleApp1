using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=DESKTOP-ABO59VD\SQLEXPRESS;Initial Catalog=CoDb;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection established successfully!");

                //Create => CRUD
                Console.WriteLine("Enter topic");
                string topic = Console.ReadLine();
                Console.WriteLine("Enter message");
                string msg = Console.ReadLine();
                string insertQuery = "INSERT INTO DETAILS(topic, msg) VALUES('"+ topic +"',"+ msg +")";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Data is successfully inserted into table!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
