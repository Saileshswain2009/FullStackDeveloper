using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Cache;

namespace OrderByMethodExample
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
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 25 }
            };
            var studentAsc = studentList.OrderBy(s => s.StudentName);
            var studentDes = studentList.OrderByDescending(s => s.Age);
            Console.WriteLine("Asending order of student name:");
            foreach (var s in studentAsc)
                Console.WriteLine(s.StudentName);
            Console.WriteLine("Descending order of student age:");
            foreach (var m in studentDes)
                Console.WriteLine(m.Age);
            var res = from n in studentList
                      orderby n.StudentName,n.Age
                      select n;
            foreach (var t in res)
                Console.WriteLine("Student Name:{0},Age{1}",t.StudentName,t.Age);
        }
    }
}
