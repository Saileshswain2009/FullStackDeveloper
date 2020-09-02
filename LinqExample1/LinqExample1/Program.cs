using System;
using System.Linq;

namespace LinqExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Sailesh", "Amit", "Bikash", "Javed", "Malika","Swagat","Sandhaya" };
            var nQuery = from str1 in str
                        where str1[2]<0
                        select str1;
            foreach(var i in nQuery)
            {
                Console.WriteLine(i + ",");
            }
        }
    }
}
