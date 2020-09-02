using System;
using System.Threading.Tasks;

namespace TaskExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>//Creating a task object and pass anonymous method to task constructor parameter as work to do within the task
            {
                return 32;
            });
            Console.WriteLine(t.Result);
            Console.WriteLine();
            Console.WriteLine("Press Enter to terminate!");
            Console.ReadLine();
        }
    }
}
