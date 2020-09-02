using System;

namespace GenericDelegate
{
    public delegate T add<T>(T param1, T param2);
    class GDelegate
    {
        static void Main(string[] args)
        {
            add<int> M1 = sum;
            Console.WriteLine("Addition is:"+M1(20, 30));
            add<int> M2 = diff;
            Console.WriteLine("Substraction is:"+M2(50, 20));
        }

        public static int sum(int val1,int val2)
        {
            return val1 + val2;
        }
        public static int diff(int val1,int val2)
        {
            return val1 - val2;
        }

    }
}
