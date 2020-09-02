using System;

namespace DelegateAnonymousMethod
{
    public delegate void dName();
    class Program
    {
        static void Main(string[] args)
        {
            dName d1 = delegate
                        {
                            Console.WriteLine("Anonymous method");
                        };
            d1();
            Console.ReadLine();
        }
    }
}
