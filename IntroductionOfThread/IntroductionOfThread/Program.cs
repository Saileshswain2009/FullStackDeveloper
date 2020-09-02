using System;
using System.Threading;

namespace IntroductionOfThread
{
    class ThreadIntro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starts here");
            //calling other method to do the task.
            ThreadIntro.DoSomeHeavyLifting();

            ThreadIntro.DoSomething();
            
        }

        public static void DoSomeHeavyLifting()
        {
            Console.WriteLine("I'm lifting a gear box");
            Thread.Sleep(1000);//Sleeps():-susupend the current thread for defined miliseconds.
            Console.WriteLine("Take a nap of 3 more miliseconds");
            Thread.Sleep(1000);
            Console.WriteLine("1.........");
            Thread.Sleep(1000);
            Console.WriteLine("2.........");
            Thread.Sleep(1000);
            Console.WriteLine("3..........");
            Console.WriteLine("I am awake now");
        }

        public static void DoSomething()
        {
            Console.WriteLine("Let's do something here!");
            for (int i = 0; i <= 10; i++)
            Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine("I'm Done");
        }
    }
}
// In this case, the DoSomething method has to wait until the DoSomeHeavyLifting method is executed.