using System;

namespace PolymorphsimExample5
{
    class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }
    }
    class Circle:Drawing
    {
        public double Raduis
        {
            get;set;
        }
        public Circle()
        {
            Raduis = 5;
        }

        public override double Area()
        {
            return 3.14 * Math.Pow(Raduis, 2);
        }
    }
    class Square:Drawing
    {
        public double Length
        {
            get;set;
        }
        public Square()
        {
            Length = 6;
        }
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
    class Rectangle : Drawing
    {
        public double Len { get; set; }
        public double Bre { get; set; }
        public Rectangle()
        {
            Len=10;
            Bre=20;
        }
        public override double Area()
        {
            return Len * Bre;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Drawing obj1 = new Circle();
            Console.WriteLine("Area of the circle: " + obj1.Area());
            Drawing obj2 = new Square();
            Console.WriteLine("Area of the square: " + obj2.Area());
            Drawing obj3 = new Rectangle();
            Console.WriteLine("Area of the rectangle: " + obj3.Area());
        }
    }
}
