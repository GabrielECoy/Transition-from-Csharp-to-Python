// Code example file for Python for the C# Developer LinkedIn Learning Course by Joe Marini
using System;

// .NET 9: Top-level statements, no namespace/class/entry point needed

// variables in C# are declared and have a type
int i = 10;
float f = 3.0f;
string s = "This is a string";
bool b = true;

// you can also use the var type which will resolve at compile time
var x = "this is a string also";

Console.WriteLine(i);
Console.WriteLine(f);
Console.WriteLine(s);
Console.WriteLine(b);
Console.WriteLine(x);

// you can't re-declare a variable once you've defined it
// b = "this is a string now";

// This also doesn't work for var types once the compiler has determined the type
// x = 5;
