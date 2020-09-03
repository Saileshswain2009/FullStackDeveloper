using System;

namespace PolymorphsimExample1
{
    class Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig:Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog:Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The dog say woo woo");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal p1 = new Pig();//Base class method overides the derived class method,when they share the same name. 
            Animal d1 = new Dog();
            a1.animalSound();
            p1.animalSound();
            d1.animalSound();
        }
    }
}
//Polymorphism uses the base class method to do different tasks.