using System;
using System.Threading;

namespace ThreadPoolThread
{
    class ThreadPool
    {
        static void BackgroundTask(Object stateInfo)
        {
            Console.WriteLine("Hello I am Worker from Thread pool");
            Thread.Sleep(1000);
        }
        static void BackGroundTaskWithObject(Object stateInfo)
        {
            Person data = (Person)stateInfo;
            Console.WriteLine($"Hi {data.Name} from ThreadPool");
            Thread.Sleep(1000);
        }
        static void Main(string[] args)
        {
            Person p = new Person("SAILESH SWAIN", 26, "Male");// Create an object and pass it to ThreadPool worker thread
            ThreadPool.QueueUserWorkItem(BackGroundTaskWithObject, p);//Passing value to background method can be done by QueueUserWorkItem().The second parameter is the object.
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public string Gender { get; set; }

            public Person(string name,int age,string gender)
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;

            }
        }
    }
}
