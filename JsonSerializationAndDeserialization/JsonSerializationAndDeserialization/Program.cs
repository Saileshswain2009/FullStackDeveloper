using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JsonSerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization");
            Movie m = new Movie { Id = 1, Title = "Khuda Hafiz" };
            string str=JsonConvert.SerializeObject(m);
            Console.WriteLine("Object is converted to string" + str);
            Console.WriteLine("\nDeserialization");
            Movie newMovie = JsonConvert.DeserializeObject<Movie>(str);
            Console.WriteLine("String is converted to object");
            Console.WriteLine("Id is:" + newMovie.Id);
            Console.WriteLine("Title is:" + newMovie.Title);
            Console.WriteLine("\n Serialization of Collection");
            List<Movie> movies = new List<Movie>
            {
                new Movie{Id=2,Title="Rocky Handsome"},
                new Movie{Id=3,Title="KGF"},
                new Movie{Id=4,Title="Golmaal"},
                new Movie{Id=5,Title="Force"}
            };
            string result=JsonConvert.SerializeObject(movies);
            Console.WriteLine(result);
            Console.WriteLine("\nDeserailization Collection String");
            List<Movie> oldMovie = JsonConvert.DeserializeObject<List<Movie>>(result);
            foreach(var i in oldMovie)
            {
                Console.WriteLine("Id is:" + i.Id + "\tTitle is:" + i.Title);
            }
        }
    }
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
