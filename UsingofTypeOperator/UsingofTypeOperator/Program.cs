using System;
using System.Linq;
using System.Collections;

namespace UsingofTypeOperator
{
    class Program
    {
		public static void Main()
		{
			IList mixedList = new ArrayList();
			mixedList.Add(0);
			mixedList.Add("One");
			mixedList.Add("Two");
			mixedList.Add(3);
			mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

			var stringResult = from s in mixedList.OfType<string>()
							   select s;

			var intResult = from s in mixedList.OfType<int>()
							select s;

			var intStudent = from s in mixedList.OfType<Student>()
							 select s;

			foreach (var str in stringResult)
				Console.WriteLine(str);
			foreach (var str1 in intResult)
				Console.WriteLine(str1);
			foreach (var str2 in intStudent)
				Console.WriteLine(str2.StudentID+","+str2.StudentName);
			
		}
	}

	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }

	}
}
