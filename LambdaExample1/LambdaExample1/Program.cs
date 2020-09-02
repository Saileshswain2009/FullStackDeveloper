using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LambdaExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            double avg = num.Where(x => x % 2 == 1).Average();
            Console.WriteLine("The average value of all odd number in this fibonacci series is: {0}",avg);
            Console.ReadLine();
        }
    }
}
