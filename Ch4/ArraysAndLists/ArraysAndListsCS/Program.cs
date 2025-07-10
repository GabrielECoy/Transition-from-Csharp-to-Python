using System;
using System.Collections.Generic;

// Top-level statements (C# 9+ / .NET 5+, fully supported in .NET 9)
var fruitlist = new List<string> { "apple", "orange", "banana", "melon" };
PrintList(fruitlist);

// Insert at an index
fruitlist.Insert(2, "grape");
PrintList(fruitlist);

// Find an item in the list
bool hasBanana = fruitlist.Contains("banana");
Console.WriteLine($"Contains banana: {hasBanana}");
int bananaIndex = fruitlist.IndexOf("baana");
Console.WriteLine($"Index of baana: {bananaIndex}");

// modify an item in-place
fruitlist[3] = "mango";
PrintList(fruitlist);

// remove an item
fruitlist.Remove("grape");
PrintList(fruitlist);

// empty the list
fruitlist.Clear();
PrintList(fruitlist);

void PrintList(List<string> theList)
{
    // Use string.Join and interpolated string for concise output
    Console.WriteLine($"[ {string.Join(" ", theList)} ]");
}
