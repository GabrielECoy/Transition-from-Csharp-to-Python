using System;

namespace InterfacesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(sideLength: 10);

            Console.WriteLine($"Square area is {s.CalcArea()}");
            Console.WriteLine($"Square to JSON code is: {s.toJSON()}");
        }
    }

    interface JSONify
    {
        public string toJSON();
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

    public class Square : GraphicShape, JSONify
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

        public string toJSON()
        {
            return ($"{{ 'square' : '{this.CalcArea()}' }}");
        }
    }
}
