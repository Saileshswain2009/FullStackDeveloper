using System;
using System.Threading;//The Thread class represents a thread and provides functionality to create and manage a thread’s lifecycle, and its properties, such as status, priority, state.The Thread class is defined in the System.Threading namespace that must be imported before you can use any threading related types.

namespace MultiThreadingIntoduction
{
    class Multithread
    {
        static void Main(string[] args)
        {
            //creating a thread with Thread keyword from thread class and passing ThreadStart delegate as parameter with method that executes in the background.
            Thread th = new Thread(new ThreadStart(Multithread.DoHeavyLifting));//ThreadStart:-represent a thread a method that executes on thread.

            th.Start();//Tell the  O.s to change the thread state.Current instance to thread running.Worker or secondary thread.

            Multithread.DoSomeThing();//Work done within a second because it is done by main thread where as DoHeavyLifting is done by other thread.
        }

        public static void DoHeavyLifting()
        {
            Console.WriteLine("Let's start the work");
            Thread.Sleep(1000);
            Console.WriteLine("Take a nap of 3 more miliseconds");
            Thread.Sleep(1000);
            Console.WriteLine("1......");
            Thread.Sleep(1000);
            Console.WriteLine("2......");
            Thread.Sleep(1000);
            Console.WriteLine("3.......");
            Console.WriteLine("I am awake now");
        }
        public static void DoSomeThing()
        {
            Console.WriteLine("Let's do some work");
            for (int j = 0; j <= 10; j++)
                Console.Write($"{j} ");
            Console.WriteLine("I am Done!");
        }
    }
}
