using System;

namespace InheritanceExample6
{
    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l,double w)
        {
            length = l;
            width = w;
        }
        public double Area()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width:  {0}", width);
            Console.WriteLine("Area:   {0}", Area());
        }
    }
    class Table:Rectangle
    {
        private double cost;
        public Table(double l,double w):base(l,w)
        {

        }
        public double GetCost()
        {
            double cost;
            cost = Area() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
    class ResultedRectangle
    {
        static void Main(string[] args)
        {
            Table obj = new Table(1.5,2.5);
            obj.Display();
        }
    }
}
