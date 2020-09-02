using System;

namespace ExceptionInDelegate
{
    public class Procedure
    {
        public static void One()
        {
            Console.WriteLine("One Display:");
            throw new Exception("Error");
        }
        public static void Two()
        {
            Console.WriteLine("Two Display:");
        }
    }
    class Operation
    {
        delegate void oDelegate();
        static void Main(string[] args)
        {
            oDelegate obj = new oDelegate(Procedure.One);
            obj += Procedure.Two;
            Delegate[] del = obj.GetInvocationList();
            foreach(oDelegate i in del)
            {
                try
                {
                    i();
                }
                catch(Exception)
                {
                    Console.WriteLine("Got Error");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
