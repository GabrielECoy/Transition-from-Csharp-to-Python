using System;
using System.Collections.Generic;

namespace DictionariesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> fileDesc = new Dictionary<string, string>();

            // add elements to the dictionary
            fileDesc.Add("pdf", "Portable Document Format");
            fileDesc.Add("txt", "Plain Text File");
            fileDesc.Add("rtf", "Rich Text Format");
            fileDesc.Add("jpg", "JPEG Image");
            fileDesc.Add("png", "Portable Network Graphics Image");

            // Get the item count
            Console.WriteLine($"The dictionary contains {fileDesc.Count} items");

            // add an element that already exists
            try
            {
                fileDesc.Add("png", "PNG File");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Key already exists in the dictionary!");
            }

            // check to see if a key exists
            bool found = fileDesc.ContainsKey("rtf");
            Console.WriteLine($"Key found: {found}");

            // check if a value exists
            found = fileDesc.ContainsValue("JPEG Image");
            Console.WriteLine($"Value found: {found}");

            // remove a single item
            fileDesc.Remove("pdf");
            Console.WriteLine($"The dictionary contains {fileDesc.Count} items");

            // clear all the elements
            fileDesc.Clear();
            Console.WriteLine($"The dictionary contains {fileDesc.Count} items");
        }
    }
}
