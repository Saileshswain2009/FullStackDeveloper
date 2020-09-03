using System;

namespace PolymorphismExample2
{
    class Bird
    {
        public void Color()
        {
            Console.WriteLine("Blue in color");
        }
    }
    class Nightangle : Bird 
    {
        public void Color()
        {
            Console.WriteLine("Having different colors");
        }
    }
    class Parrot:Bird
    {
        public void Color()
        {
            Console.WriteLine("Green in color");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Bird obj1 = new Bird();
            Bird obj2 = new Nightangle();
            Bird obj3 = new Parrot();
            obj1.Color();
            obj1.Color();
            obj1.Color();
        }
    }
}
