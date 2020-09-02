using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsingRunMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name="Main Thread";

            Task RMethod = Task.Run(() =>
                                      Console.WriteLine("Hello from Rmethod"));
    
            Console.WriteLine("Hello from Thread: {0}", Thread.CurrentThread.Name);
            RMethod.Wait();//to wait the Rmethod thread after execution of hello from thread we must use threadName.wait() after Hello from Thread.
        }
    }
}
