using System;
using System.Threading.Tasks;

namespace TaskExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> obj = Task.Run(() =>
            {
                return 32;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            obj.ContinueWith((i) =>
            {
                
                Console.WriteLine(i.Result);
 
            });
            Console.WriteLine("Please Enter to terminate!");
            Console.ReadLine();
        }
    }
}
