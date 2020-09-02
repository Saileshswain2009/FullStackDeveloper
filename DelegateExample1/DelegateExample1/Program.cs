using System;

namespace DelegateExample1
{
    public delegate void Ramesh(string msg);
    class SimpleDelegate
    {
        static void Main(string[] args)
        {
            Ramesh del1 = A.Ankit;//Directly assign a target method without creating delegate object.
            del1("Hello to Delegate chapter 1");

            Ramesh del2 = B.Sandeep;//Directly assign a target method without creating delegate object.
            del2("Hello to Delegate chapter 2");

            Ramesh del3 = new Ramesh(A.Ankit);//Assigning target method using delegate object.
            del3("Hello to Delegate chapter 3");

            Ramesh del4 = new Ramesh(B.Sandeep);//Assigning target method using delegate object.
            del4("Hello to Delegate chapter 4");

            Ramesh del5 = (string msg1) => Console.WriteLine(msg1);//Using lambda Expression.
            del5("Hello to Delegate chapter 5");
        }
        
    }
    class A
    {
        public static void Ankit(string message)
        {
            Console.WriteLine("called class-A method with parameter:" + message);
        }
    }
    class B
    {
        public static void Sandeep(string message)
        {
            Console.WriteLine("called Class-B method with parameter:" + message);
        }
    }
}
