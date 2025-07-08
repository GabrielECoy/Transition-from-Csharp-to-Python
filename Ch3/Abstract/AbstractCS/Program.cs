
using System;

// Top-level statements and file-scoped types (C# 10+ / .NET 6+)
var c = new Circle(5);
var s = new Square(10);

Console.WriteLine($"Circle area is {c.CalcArea()}");
Console.WriteLine($"Square area is {s.CalcArea()}");

// Abstract classes cannot be directly instantiated by the consumer
abstract class GraphicShape
{
    public abstract double CalcArea();
}

class Circle(int radius) : GraphicShape
{
    public override double CalcArea() => Math.PI * Math.Pow(radius, 2);
}

class Square(int sideLength) : GraphicShape
{
    public override double CalcArea() => Math.ScaleB(sideLength, 1);
}
