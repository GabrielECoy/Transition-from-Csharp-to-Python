using System;

namespace MagicMethodsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicMethods mmobj1 = new MagicMethods("thing1", 20);
            MagicMethods mmobj2 = new MagicMethods("thing2", 30);
            MagicMethods mmobj3 = new MagicMethods("thing1", 20);

            Console.WriteLine(mmobj1.ToString());

            Console.WriteLine(mmobj1.Equals(mmobj2));
            Console.WriteLine(mmobj1.Equals(mmobj3));
        }
    }
}
