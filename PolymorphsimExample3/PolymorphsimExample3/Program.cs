using System;

namespace PolymorphsimExample3
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says : wee wee");
        }
    }
    class Dog:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says : woo woo");
        }
    }
    class Pet
    {
        static void Main(string[] args)
        {
            Animal obj1 = new Animal();
            Animal obj2 = new Pig();
            Animal obj3 = new Dog();//Here we share the name base class name but we use vitual in base class method and overide in all derived class method.
            obj1.animalSound();
            obj2.animalSound();
            obj3.animalSound();
        }
    }
}
