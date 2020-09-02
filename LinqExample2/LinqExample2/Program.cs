using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Cache;

namespace LinqExample2
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var nQuery = from std in studentList
                         where std.Age > 12 && std.Age < 20
                         select std;
            foreach(var i in nQuery)
            {
                Console.WriteLine(i.StudentName + ",");
            }

        }
    }
}
