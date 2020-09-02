using System;

namespace DelegateWithParameter2
{
    public delegate void sandeep(string str);
    class DelParam
    {
        static void Main(string[] args)
        {
            sandeep obj = new sandeep(A.M1);
            Z(obj);

            obj = B.M2;
            Z(obj);

            obj = (string str) => Console.WriteLine("Called lambda expression:" + str);
            Z(obj);
        }
        static void Z(sandeep obj)//Passing delegate parameter
        {
            obj("Hello Sandeep");
        }
    }
    class A
    {
        public static void M1(string str)
        {
            Console.WriteLine("Welcome to M1 method:", str);
        }
    }
    class B
    {
        public static void M2(string str)
        {
            Console.WriteLine("Welcome to M2 method:", str);
        }
    }
}
