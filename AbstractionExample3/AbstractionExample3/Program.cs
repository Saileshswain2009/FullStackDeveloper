using System;

namespace AbstractionExample3
{
    abstract class Dimension
    {
        public abstract int Area();
    }
    class Rectangle:Dimension
    {
        private int len, bre;
        public Rectangle(int x,int y)
        {
            len = x;
            bre = y;
        }
        public override int Area()
        {
            int result = len * bre;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle(10,40);
            Console.WriteLine("Area of rectangle is {0}", obj.Area());
        }
    }
}
