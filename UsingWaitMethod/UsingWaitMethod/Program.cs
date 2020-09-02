using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsingWaitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Task one = Task.Run(() => Thread.Sleep(2000));// Wait on a single task with a timeout specified.
            try
            {
                one.Wait(3000);//wait for 1 second.
                bool comp = one.IsCompleted;
                Console.WriteLine("Task one is Completed:{0},Status:{1}", comp, one.Status);
                if (!comp)
                    Console.WriteLine("Timed out before Task one complete.");
            }
            catch(AggregateException)
            {
                Console.WriteLine("Exception in Task one");
            }
        }
    }
}
