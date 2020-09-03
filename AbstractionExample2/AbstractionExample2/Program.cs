using System;

namespace AbstractionExample2
{
    abstract class Mobile
    {
        public abstract void Features();
        public void Design()
        {
            Console.WriteLine("I-phone having highest number of features");
        }
    }
    class Gadget:Mobile
    {
        public override void Features()
        {
            Console.WriteLine("x-series is having good features");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gadget g1 = new Gadget();
            g1.Design();
            g1.Features();
        }
    }
}
