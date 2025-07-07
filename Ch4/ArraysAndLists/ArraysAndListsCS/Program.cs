using System;
using System.Collections.Generic;

namespace ArraysAndListsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list
            List<string> fruitlist = new List<string>();

            // Add some items
            fruitlist.Add("apple");
            string[] fruits = { "orange", "banana", "melon" };
            fruitlist.AddRange(fruits);
            PrintList(fruitlist);

            // Insert at an index
            fruitlist.Insert(2, "grape");
            PrintList(fruitlist);

            // Find an item in the list
            bool b = fruitlist.Exists(s => s.Equals("banana"));
            Console.WriteLine($"{b}");
            int i = fruitlist.IndexOf("banana");
            Console.WriteLine($"{i}");

            // modify an item in-place
            fruitlist[3] = "mango";
            PrintList(fruitlist);

            // remove an item
            fruitlist.Remove("grape");
            PrintList(fruitlist);

            // empty the list
            fruitlist.Clear();
            PrintList(fruitlist);
        }

        static void PrintList(List<string> theList)
        {
            Console.Write("[ ");
            foreach (string s in theList)
            {
                Console.Write(s);
                Console.Write(" ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
