using System;
using System.Security.Cryptography.X509Certificates;


namespace SimpleDelegate1
{
    public delegate int operation1(int m1, int m2);

    class DelegateOperation
    {
        static int diff(int x1, int x2)
        {
            return x1 - x2;
        }
        public static void Main(string[] args)
        {
            operation1 obj = new operation1(DelegateOperation.diff);
            Console.WriteLine("The Difference is:{0}", obj(100, 20));
            Console.ReadLine();
        }
    }
}
