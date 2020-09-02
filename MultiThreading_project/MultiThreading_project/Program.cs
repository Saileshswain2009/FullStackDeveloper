using System;
using System.Threading;

namespace MultiThreading_project
{
    class MultiThreading
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(threadA);
            t1.Start();
            t1.Priority = ThreadPriority.Lowest;//Current thread comes at last to execute.
            for(int j=0;j<5;j++)
            {
                Console.WriteLine("Main-Thread");
                Thread.Sleep(1000);
            }
            if(t1.IsAlive)
            {
                t1.Start();
                t1.Abort();//stop the Current thread.
            }
        }
        public static void threadA()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Thread-A");
                Thread.Sleep(500);
            }
        }
    }
}
