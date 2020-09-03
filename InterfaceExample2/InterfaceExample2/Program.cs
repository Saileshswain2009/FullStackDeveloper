using System;

namespace InterfaceExample2
{
    class Book
    {
        public string Bname = "Geeta";
        public void Bdis()
        {
            Console.WriteLine("Its very useful to live happy life");
        }
    }
    class chapter:Book
    {
        public string Cname = "Intoduction";
        public void Chap1()
        {
            Console.WriteLine("Holy Indian Book");
        }
    }
    class Reading
    {
        static void Main(string[] args)
        {
            chapter c1 = new chapter();
            c1.Chap1();//Holy indian book
            Console.WriteLine(c1.Bname + " " + c1.Cname);//Geeta Intro
            c1.Bdis();
        }
    }
}
