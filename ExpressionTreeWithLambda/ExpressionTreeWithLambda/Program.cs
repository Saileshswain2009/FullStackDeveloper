using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTreeWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pin = { 3, 8, 4, 6, 1, 7, 9, 2, 4, 8 };
            foreach (int i in pin.Where(x =>
             {
                 if (x <= 3)
                     return true;
                 else if (x >= 7)
                     return true;
                 return false;
             }
            )
            )
                Console.WriteLine(i);
        }
    }
}
