using System;

namespace InheritanceExample3
{
    class Sports
    {
        public int player;
        public void Cricket()
        {
            Console.WriteLine("Used to play with 11 players");
        }
    }
    class Games:Sports
    {
        public void Football()
        {
            Console.WriteLine("Messi is a great player in Football");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Games obj = new Games();
            obj.Cricket();
            obj.player = 20;
            Console.WriteLine(obj.player);
            obj.Football();
        }
    }
}
