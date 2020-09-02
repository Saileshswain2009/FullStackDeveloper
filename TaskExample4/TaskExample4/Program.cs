using System;
using System.Threading.Tasks;

namespace TaskExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 32;
            });
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Cancalled");
            },TaskContinuationOptions.OnlyOnFaulted);
            var completedTask = t.ContinueWith((i) =>
              {
                  Console.WriteLine(i.Result);
                  Console.WriteLine("Completed");
              }, TaskContinuationOptions.OnlyOnRanToCompletion);
            Console.WriteLine("Press Enter to terminate");
            Console.ReadLine();
        }
    }
}
