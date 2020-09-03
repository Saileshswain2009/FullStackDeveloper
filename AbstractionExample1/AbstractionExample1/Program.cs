using System;

namespace AbstractionExample1
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Pig:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig say wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig obj = new Pig();
            obj.animalSound();
            obj.sleep();
        }
    }
}
