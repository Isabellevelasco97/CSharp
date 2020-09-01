using System;

// The derived class inherits the base class variables and methods
// so base class should be created first

namespace RectangleApplication
{
    class Rectangle
    {
        protected double length;
        protected double width;
        // base class variables
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class Tabletop: Rectangle
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w) { }

        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        // public void Display()
        // {
        //     base.Display();
        //     Console.WriteLine("Cost: {0}", GetCost());
        // }
    }

    class ExecuteRectangle
    {
        static void notMain(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadLine();
        }
    }
}