// Example HelloWorld file for the Python for the C# Developer LinkedIn Learning course

using System;
using System.IO;

namespace ScopesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFile = "MyTextFile.txt";
            int linecount = 0;
            string line;
            // The C# scope block is defined by the using statement
            using (StreamReader file = new StreamReader(textFile))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    linecount++;
                }
                file.Close();
                Console.WriteLine($"File has {linecount} lines.");
            }
        }
    }
}
