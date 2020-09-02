using System;

namespace MultipleDeligateExample2
{
    public delegate void rita(int z);
    class Program
    {
        static void Main(string[] args)
        {
            rita obj = new rita(M.muti);
            obj += M.div;
            obj(200);
        }
    }
    class M
    {
        public static void muti(int a1)
        {
            Console.WriteLine("Multiplication is: {0}", a1*2);
        }
        public static void div(int a2)
        {
            Console.WriteLine("Division is: {0}", a2 / 10);
        }
    }
}
