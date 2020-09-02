using System;

namespace ArrayDelegate
{
    public class Execute
    {
        public static void Add(int x,int y)
        {
            Console.WriteLine("Addition={0}", x + y);
        }
        public static void Multiply(int x,int y)
        {
            Console.WriteLine("Multiplication={0}", x * y);
        }
    }
    class Test
    {
        public delegate void Math(int a, int b);//If method having no return type then return type of delegate is void.
        static void Main(string[] args)
        {
            Math[] m1 = {
                            new Math(Execute.Add),
                            new Math(Execute.Multiply)
                        };
            for(int i=0;i<m1.Length;i++)
            {
                m1[i](2, 4);
                m1[i](10, 20);
            }
            Console.ReadLine();
        }
    }
}
