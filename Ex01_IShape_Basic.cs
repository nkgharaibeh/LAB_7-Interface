using System;
    // In Lab 6 we had: abstract class Shape { public abstract double CalculateArea(); }
    // Now we use an INTERFACE as a pure contract (no fields, no implementation).
namespace Ex01_IShape_Basic
{
    
    interface IShape
    {
        // Contract: any shape MUST provide an implementation for CalculateArea().
        double CalculateArea();
    }

    class Circle : IShape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : IShape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main()
        {
            IShape s1 = new Circle(3);
            IShape s2 = new Rectangle(4, 5);

            Console.WriteLine("Circle area = " + s1.CalculateArea());
            Console.WriteLine("Rectangle area = " + s2.CalculateArea());

            Console.ReadKey();
        }
    }
}

/*
KEY NOTES (from slides + previous labs):

- Abstract class vs Interface:
    * abstract class Shape: can have fields + some implementation.
    * interface IShape: only signatures => "pure abstraction, no storage".

- We still get RUNTIME POLYMORPHISM:
    IShape variable -> Circle or Rectangle object.
*/
