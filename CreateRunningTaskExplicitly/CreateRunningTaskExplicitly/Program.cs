using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreateRunningTaskExplicitly
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Sailesh";
            Task taskA = new Task(() => Console.WriteLine("Hello to Task World")); // Create a task and supply a user delegate by using a lambda expression.
            taskA.Start();
            Console.WriteLine("Hello from {0}", Thread.CurrentThread.Name);
            taskA.Wait(10);
        }
    }
}
