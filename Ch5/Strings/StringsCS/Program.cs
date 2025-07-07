// Example HelloWorld file for the Python for the C# Developer LinkedIn Learning course

using System;
using System.Text;

namespace StringsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic string operations
            string thestr = "The quick brown fox jumps over the lazy dog";
            string alpha1 = "abcdef";
            string alpha2 = "ABCDEF";

            // Get the string length
            Console.WriteLine(thestr.Length);

            // Working with substrings
            Console.WriteLine(thestr);
            Console.WriteLine(thestr.StartsWith("The"));
            Console.WriteLine(thestr.EndsWith("dog"));
            Console.WriteLine(thestr.Contains("fox"));
            Console.WriteLine(thestr.Substring(4, 5)); // "quick"
            string newstr = thestr.Replace("fox", "cat");
            Console.WriteLine(newstr);

            // String concatenation
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }
            Console.WriteLine(sb);

            // String interpolation (as of C# 6)
            string interp = $"Lower case letters are {alpha1}, uppercase are {alpha2}";
            string interp2 = $"{alpha1.Length}";
            Console.WriteLine(interp);
            Console.WriteLine(interp2);
        }
    }
}
