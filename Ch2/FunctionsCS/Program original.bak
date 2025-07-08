using System;
using System.Collections.Generic;

namespace FunctionsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // call a function with a return value
            int result = RegularFunction(5, 10);
            Console.WriteLine(result);

            // call a function with named parameters
            NamedParams(5, "world", false);
            NamedParams(c: true, b: "hello", a: 5);

            // use the variable arguments example
            VariableParams(1, 'a', 3.05f, "test");

            // Try the lambda function
            LambdaFunc();
        }

        static int RegularFunction(int a, int b)
        {
            // C# lets you change the value of an "out" parameter
            Console.WriteLine($"{a + b}");

            // This is a function that returns an integer
            return 42;
        }

        static void NamedParams(int a, string b, bool c = false)
        {
            // This function returns nothing
            if (c)
            {
                Console.WriteLine("'a' comes first");
                Console.WriteLine("{0}", a);
                Console.WriteLine("{0}", b);
            }
            else
            {
                Console.WriteLine("'b' comes first");
                Console.WriteLine("{0}", b);
                Console.WriteLine("{0}", a);
            }
        }

        static void VariableParams(int a, int b, params object[] args)
        {
            Console.WriteLine($"{a + b}");
            foreach (object arg in args)
            {
                Console.WriteLine("Argument: " + arg);
            }
        }

        static void LambdaFunc()
        {
            // define a list of integers
            List<int> data = new List<int> { 10, 6, 23, 15, 18, 59, 62, 7, 103, 29, 35 };

            // Sort the list using default sorting
            Console.WriteLine("Regular sort:");
            data.Sort();
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }

            // Sort the list with a lambda function
            Console.WriteLine("Sort by first digit:");
            data.Sort((a, b) => (a.ToString()[0].CompareTo(b.ToString()[0])));
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }
        }
    }
}
