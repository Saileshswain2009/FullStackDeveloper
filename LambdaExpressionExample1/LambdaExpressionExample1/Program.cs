using System;

namespace LambdaExpressionExample1
{
    class Program
    {
        delegate int del(int i); 
        static void Main(string[] args)
        {
            del myDelegate = y => y * y;
            int j = myDelegate(5);
            Console.WriteLine("The result is:{0}",j);
            Console.ReadLine();
        }
    }
}
