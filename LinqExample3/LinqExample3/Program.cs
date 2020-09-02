using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample3
{
    public class Sports
    {
        public int PlayerNum { get; set; }
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Sports> Slist = new List<Sports>()
            {
                new Sports(){PlayerNum=10,PlayerName="Messi",PlayerScore=100},
                new Sports(){PlayerNum=7,PlayerName="Cristanio",PlayerScore=220},
                new Sports(){PlayerNum=11,PlayerName="Kaka",PlayerScore=500},
                new Sports(){PlayerNum=12,PlayerName="Mika",PlayerScore=550},
                new Sports(){PlayerNum=15,PlayerName="Ritz",PlayerScore=250},
                new Sports(){PlayerNum=8,PlayerName="Neymar",PlayerScore=50},
            };
            var nQuery = from res in Slist
                         where res.PlayerScore > 200 && res.PlayerScore < 520
                         select res;
            foreach(var i in nQuery)
            {
                Console.WriteLine("The name of the players who score 200 to 520 goals are: {0}", i.PlayerName);
            }
        }
    }
}
