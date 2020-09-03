using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADODOTNET
{
    class DAL
    {
        public void ReadAndPrint()
        {
            String connString = @"Data Source=(local);Initial Catalog=SPORTS_DB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string sqlQuery = "Select * from dbo.Students";
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    Int32 id = (Int32)reader.GetValue(0);
                    Int32 id2 = reader.GetInt32(0);
                    Int32 id3 = reader.GetInt32(reader.GetOrdinal("StudentID"));

                    Console.WriteLine("Id is:{0}", id);
                    Console.WriteLine("Name is:{0}", reader.GetString(1));
                    Console.WriteLine("DoB is:{0}", reader.GetDateTime(2));
                    Console.WriteLine("----------------------------------");
                }
            }
        }

        public void Save(int pStudentId,String pName,DateTime pDOB)
        {
            String connString = @"Data Source=(local);Initial Catalog=SPORTS_DB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string sqlQuery = String.Format(@"INSERT INTO dbo.Students(StudentID,Name,DOB)
                                                VALUES('{0}','{1}','{2}')", pStudentId, pName, pDOB);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                try
                {
                    int recAff = command.ExecuteNonQuery();
                    Console.WriteLine("Records Effected {0}", recAff);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void Update(Int32 pStudentId,String pName,DateTime pDOB)
        {
            String connString = @"Data Source=(local);Initial Catalog=SPORTS_DB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string sqlQuery = String.Format(@"UPDATE dbo.Students Name='{0}',DOB='{1}' WHERE StudentID={2}", pName, pDOB,pStudentId);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                try
                {
                    int recAff = command.ExecuteNonQuery();
                    Console.WriteLine("Records Effected {0}", recAff);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void Delete(int pStudentId)
        {
            String connString = @"Data Source=(local);Initial Catalog=SPORTS_DB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string sqlQuery = String.Format(@"DELETE FROM dbo.Students WHERE StudentID={0}", pStudentId);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                int recAff = command.ExecuteNonQuery();
                Console.WriteLine("Records Effected {0}", recAff);
            }
        }
    }
}
