using System;
using System.Threading;
using System.Threading.Tasks;

namespace WaitOneOrMoreTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() => Thread.Sleep(5000));
            Console.WriteLine("Staus of t1 thread is: {0} ", t1.Status);
            try
            {
                t1.Wait();
                Console.WriteLine("Status of thread inside try block is: {0}", t1.Status);
            }
            catch(AggregateException)
            {
                Console.WriteLine("Exception in Task t1");
            }
        }
    }
}
