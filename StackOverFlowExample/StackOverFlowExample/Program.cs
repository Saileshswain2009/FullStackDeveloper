using System;
using System.Threading;

namespace StackOverFlowExample
{
    class Program
    {
        static void Repeat(int x)
        {
            
            try
            {
                Console.WriteLine(x);
                Repeat(++x);
            }
            catch(StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Repeat(0);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
