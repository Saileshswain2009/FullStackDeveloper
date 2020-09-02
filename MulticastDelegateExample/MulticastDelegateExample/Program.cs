using System;

namespace MulticastDelegateExample
{
    public delegate void mDelegate(int x);
    class MultiDelegate
    {
        static void Main(string[] args)
        {
            mDelegate m1 = new mDelegate(TwoDeligate.Add);
            m1 += TwoDeligate.Square;//Calling multiple method(+=) 
            m1(5);
            m1(6);
        }
    }
    class TwoDeligate
    {
        public static void Add(int a)
        {
            Console.WriteLine("Addition is:{0}",a+20);
        }
        public static void Square(int b)
        {
            Console.WriteLine("Square is:{0}", b*5);
        }
    }
}
