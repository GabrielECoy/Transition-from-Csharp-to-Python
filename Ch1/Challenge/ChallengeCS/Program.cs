using System;

namespace ChallengeCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RunningTally(tm)");
            Console.WriteLine("Enter a number to start the tally, enter 'quit' to stop");
            bool run = true;
            int total = 0;
            while (run)
            {
                string input = Console.ReadLine();
                if (input.Equals("quit"))
                {
                    run = false;
                }
                else
                {
                    int val;
                    // see if it's a number
                    if (int.TryParse(input, out val))
                    {
                        total += val;
                        Console.WriteLine("> {0}", total);
                    }
                }
            }
        }
    }
}
