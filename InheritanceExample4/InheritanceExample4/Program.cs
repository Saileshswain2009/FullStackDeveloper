using System;

namespace InheritanceExample4
{
    class Shape
    {
        protected int width, height;
        public void SWidth(int w)
        {
            width = w;
        }
        public void SHeight(int h)
        {
            height = h;
        }
    }
    class Rectangle:Shape
    {
        public int Area()
        {
            return (width * height);
        }
    }
    class Geomatry
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SWidth(10);
            rect.SHeight(20);
            Console.WriteLine("Total area is {0}", rect.Area());
        }
    }
}
