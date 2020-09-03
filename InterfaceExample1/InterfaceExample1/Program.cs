using System;

namespace InterfaceExample1
{
    interface IAnimal
    {
        void animalSound();
    }
    class Dog:IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Sounds like woo woo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.animalSound();
        }
    }
}
