using System;

namespace MultiCastDelegateWithReturnValue
{
    public delegate int MyDelegate(); //declaring a delegate

    class MultDelArg
    {
        static void Main(string[] args)
        {
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            MyDelegate del = del1 + del2;
            Console.WriteLine(del());// returns 200
        }
    }

    class ClassA
    {
        public static int MethodA()
        {
            return 100;
        }
    }

    class ClassB
    {
        public static int MethodB()
        {
            return 200;
        }
    }

}
