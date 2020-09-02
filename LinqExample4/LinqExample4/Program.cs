using LinqExample4;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqExample4
{
    public class Books
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int pages { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IList<Books> b1 = new List<Books>()
            {
                new Books(){Number=10,Name="SportsStar",pages=220},
                new Books(){Number=20,Name="IndiaToday",pages=200},
                new Books(){Number=30,Name="TimesOfIndia",pages=320},
                new Books(){Number=50,Name="IndianExpress",pages=520},
                new Books(){Number=40,Name="Pnchantratra",pages=820},
            };
            var nQuery = b1.Where(s => s.pages > 200 && s.pages < 600).ToList<Books>();

            var orderByResult = from s in b1
                                orderby s.Number
                                select s;
            foreach (var book1 in orderByResult)
                Console.WriteLine("Accesending order: " + book1.Number);
            var orderByResult1 = from s in b1
                                 orderby s.Number descending
                                 select s;
            foreach (var book2 in orderByResult1)
                Console.WriteLine("Desending order: " + book2.Number);
            

            foreach(var i in nQuery)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
//ofType():-It searches elements by their type only.