using System;
using System.Threading;

namespace CreateAndStartNewThread
{
    class CreateThread
    {
        static void Main(string[] args)
        {
            Thread obj = new Thread(new ThreadStart(DoSomeCoding));//Thread Constructor takes a threadsTart Delegate as a parameter and creates a new thread.The parameter of the ThreadStart is the method that is executed by the new thread. Once a thread it created, it needs to call the Start method to actually start the thread.
            obj.Start();
            if (obj.IsAlive)//isAlive:-to check wheather a thread is alive or not.If Alive then stop through abort().
                obj.Abort();
            CreateThread.DoSomeExcercise();
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine("Thread Name is:{0}",Thread.CurrentThread.Name);
            Console.WriteLine("Thread Id: {0} ", currentThread.ManagedThreadId);
            Console.WriteLine("Is thread background: {0}", currentThread.IsBackground);
            Console.WriteLine("Priority: {0}", currentThread.Priority);
            Console.WriteLine("Culture: {0}", currentThread.CurrentCulture.Name);
            Console.WriteLine("UI Culture: {0}", currentThread.CurrentUICulture.Name);
            Console.WriteLine();
        }
        public static void DoSomeExcercise()//Thread Execution always start with main method.So,Main method related method calling will execute first after that new threads.
        {
            Console.WriteLine("Start the Excercise!");
            Thread.Sleep(2000);//When main method thread sleep then new thread execute and when new thread sleeps main method thread executes.
            Console.WriteLine("I am Done with my excercise");
        }
        public static void DoSomeCoding()
        {
            Console.WriteLine("Coding is joyfull job!");
            Thread.Sleep(1000);//Depend upon sleep time threads will executes.
            Console.WriteLine("I done my coding");
        }
        
    }
}
