using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = @"Data Source=(local);Initial Catalog=master;Integrated Security=True";
            SQLConnection conn = new SQLConnection(ConnectionString);
            try
            {
                conn.Open();
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Connection success");
        }
    }
}
