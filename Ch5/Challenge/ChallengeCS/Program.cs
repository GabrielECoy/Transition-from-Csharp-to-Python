using System;
using System.Collections.Generic;

namespace ChallengeCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to convert to PigLatin:");
            string inputstr = Console.ReadLine();
            string piglatinstr = ToPigLatin(inputstr);
            Console.WriteLine("The result is:");
            Console.WriteLine(piglatinstr);
        }

        static string ToPigLatin(string sentence)
        {
            const string vowels = "AEIOUaeiou";
            List<string> plWords = new List<string>();
            string[] curWords = sentence.Split(' ');

            foreach (string word in curWords)
            {
                // If the word start with a vowel, add "way" to the end
                if (vowels.Contains(word[0]))
                {
                    plWords.Add(word + "way");
                }
                else
                {
                    // Find position of the first vowel, then move the consonants
                    // up to that point to the end of the word
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (vowels.Contains(word[i]))
                        {
                            string prefix = word.Substring(0, i);
                            string suffix = word.Substring(i);
                            string newWord = suffix + prefix + "ay";
                            plWords.Add(newWord);
                            break;
                        }
                    }
                }

            }
            return string.Join(" ", plWords);
        }
    }
}
