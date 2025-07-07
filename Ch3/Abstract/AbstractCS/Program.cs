using System;

namespace AbstractCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(radius: 5);
            Square s = new Square(sideLength: 10);

            Console.WriteLine($"Circle area is {c.CalcArea()}");
            Console.WriteLine($"Square area is {s.CalcArea()}");
        }
    }

    // Abstract classes cannot be directly instantiated by the consumer
    public abstract class GraphicShape
    {
        public GraphicShape()
        {
        }

        // abstract functions must be overridden by subclasses
        public abstract double CalcArea();
    }

    public class Circle : GraphicShape
    {
        protected int _radius;
        public Circle(int radius)
        {
            this._radius = radius;
        }

        public override double CalcArea()
        {
            return (Math.PI * (_radius ^ 2));
        }
    }

    public class Square : GraphicShape
    {
        protected int _sideLength;

        public Square(int sideLength)
        {
            this._sideLength = sideLength;
        }

        public override double CalcArea()
        {
            return (_sideLength * _sideLength);
        }
    }
}
