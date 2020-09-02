using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(() =>
              {
                  for (int i = 0; i < 5; i++)
                  {
                      var threadId = Thread.CurrentThread.ManagedThreadId;
                      Console.WriteLine("Task Loop Current Thread Id:" + threadId);
                  }
              });
            t.Start();

            for(int i=0;i<5;i++)
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine("Main Loop current thread Id:" + threadId);
            }
            t.Wait();
            Console.WriteLine("Press enter terminate the process!");
            Console.ReadLine();
        }
    }
}
