using System;
using System.Security.Cryptography.X509Certificates;

namespace InheritanceExample1
{
    class A
    {
        public int x=20;
        public  void B()
        {
            Console.WriteLine("Happy world");
        }
    }
    class C:A
    {
        public int y = 30; 
        public void D()
        {
            Console.WriteLine("Greedy World");
        }
    }
    class M
    {
        static void Main(string[] args)
        {
            C c1 = new C();
            c1.B();
            Console.WriteLine(c1.x + " " + c1.y);//Throygh the refernce of derived class we can access the data members of base class.
            c1.D();
        }
    }
}
