// .NET 9: Top-level statements, no namespace/class/entry point needed
using System;

int x = 10;
int y = 20;
int z = 30;

// C# provides if-else and switch-case
if (x < y)
{
    Console.WriteLine("result #1");
}
// This condition can never be true because if x < y, the first if block executes, so this else-if is unreachable
else if (y > z && x < y)
{
    Console.WriteLine("result #2");
}
else
{
    Console.WriteLine("result #3");
}

switch (x)
{
    // note the fall-through on the case statements
    case 10:
    case 20:
        Console.WriteLine("result #1");
        break;
    case 30:
        Console.WriteLine("result #2");
        break;
}

Console.WriteLine(z < y ? "result #4" : "result #5");
