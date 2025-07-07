// Python for the C# Developer by Joe Marini
// Example code file for

// .NET 9: Top-level statements, no namespace/class/entry point needed
using System;

int i = 0;
// for and foreach-in
string str = "Hello World!";
for (i = 0; i < str.Length; i++)
{
    char c = str[i];
    if (c == 'o')
        continue;
    Console.Write("{0},", c);
}
Console.WriteLine();

foreach (char c in str)
{
    Console.Write("{0},", c);
}
Console.WriteLine();

// while loops
bool keepgoing = true;
i = 0;
while (keepgoing)
{
    Console.WriteLine("Num: {0}", i++);
    if (i == 10)
        keepgoing = false;
}

// do-while
keepgoing = true;
i = 0;
do
{
    Console.WriteLine("Num: {0}", i++);
    if (i == 5)
        keepgoing = false;
} while (keepgoing);
