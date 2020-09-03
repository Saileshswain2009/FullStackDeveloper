using System;

namespace MultipleInterfaceExample1
{
    interface IPlace
    {
        void Home();
    }
    interface ITour
    {
        void Sceneries();
    }
    class Enjoy:IPlace,ITour
    {
        public void Home()
        {
            Console.WriteLine("Home is a mini temple");
        }
        public void Sceneries()
        {
            Console.WriteLine("Once in a year we must go for a tour");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Enjoy e1 = new Enjoy();
            e1.Home();
            e1.Sceneries();
        }
    }
}
